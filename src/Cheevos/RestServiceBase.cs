namespace PolyhydraGames.RACheevos;

public static class Urls
{
    public static string SystemImagePrefix_32x = "https://static.retroachievements.org/assets/images/system/32x.png";
    public static string GameLink = "https://retroachievements.org/game/";
}
public class CustomDateFormatConverter : System.Text.Json.Serialization.JsonConverter<DateTime>
{
    private readonly string dateFormat = "yyyy-MM-dd HH:mm:ss";

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string dateString = reader.GetString();
        try
        {
            return DateTime.Parse(dateString);
        }
        catch (Exception ex)
        {
            return DateTime.ParseExact(dateString, dateFormat, null);
        }

    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(dateFormat));
    }
}

public class RestServiceBase
{
    protected ICheevoAuth AuthConfig { get; set; }
    private readonly HttpClient _client;
    public const string BaseUrl = "https://retroachievements.org/API";
    protected string GetBaseUrl([CallerMemberName] string memberName = "")
    {
        var url = BaseUrl + "/API_" + memberName + ".php?";
        return url.ApiKey(AuthConfig.ApiKey).AuthUser(AuthConfig.UserName);
    }
    public RestServiceBase(ICheevoAuth config, HttpClient client)
    {
        AuthConfig = config;
        _client = client;
    }
    //protected readonly IHttpService _httpService;

    protected bool AuthRequired { get; set; }

    protected JsonSerializerOptions Options { get; set; } = new JsonSerializerOptions()
    {
        PropertyNameCaseInsensitive = true,
        Converters = { new CustomDateFormatConverter() }
    };



    protected Uri Uri(string query)
    {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
        interpolatedStringHandler.AppendFormatted(BaseUrl);
        interpolatedStringHandler.AppendLiteral("/");
        //interpolatedStringHandler.AppendFormatted(this.Service);
        //interpolatedStringHandler.AppendLiteral("/");
        interpolatedStringHandler.AppendFormatted(query);
        return new System.Uri(interpolatedStringHandler.ToStringAndClear());
    }

    private Exception OnUnauthorized()
    {
        return new Exception(this.AuthRequired
            ? "Unauthorized"
            : "AuthRequired was not enabled, but the endpoint claims that authorization is required. Did you miss setting AuthRequired?");
    }

    protected async Task<T> Get<T>(string url)
    {
        Debug.WriteLine(url);
        HttpClient client = this._client;
        HttpResponseMessage httpResponseMessage = await client.GetAsync(url);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            var responseString = await httpResponseMessage.Content.ReadAsStringAsync();
            try
            {
                T obj = JsonSerializer.Deserialize<T>(responseString, this.Options);
                return obj;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(responseString);
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        if (httpResponseMessage.StatusCode == HttpStatusCode.Unauthorized)
            throw this.OnUnauthorized();
        throw new Exception(httpResponseMessage.StatusCode.ToString() + ":" + httpResponseMessage.ReasonPhrase);
    }

    protected async Task<HttpRequestMessage> GetHttpRequestMessage(string method, HttpMethod httpMethod, HttpContent content = null)
    {
        return new HttpRequestMessage()
        {
            RequestUri = this.Uri(method),
            Method = httpMethod,
            Content = content
        };
    }

}