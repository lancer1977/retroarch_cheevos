namespace PolyhydraGames.RACheevos;
public interface IAuthConfig
{
    public string ApiKey { get; }
    public string UserName { get; }

}
public static class AppendExtensions
{
    public static string Offset(this string url, int? offset)
    {
        if (offset == null)
        {
            return url;
        }
        return url + $"&o={offset}";
    }

    public static string Count(this string url, int? count)
    {
        if (count == null)
        {
            return url;
        }
        return url + $"&c={count}";
    }

    public static string Kinds(this string url, string? kinds)
    {
        if (kinds == null)
        {
            return url;
        }
        return url + $"&k={kinds}";
    }

    public static string Date(this string url, DateTime? date)
    {
        if (date == null)
        {
            return url;
        }
        return url + $"&d={date:yyyy-MM-dd}";
    }
}
public class RestServiceBase
{
    protected IAuthConfig AuthConfig { get; set; }
    private readonly HttpClient _client;
    public const string BaseUrl = "https://retroachievements.org/API";
    protected string GetBaseUrl([CallerMemberName] string memberName = "")
    {
        return BaseUrl + "/API_" + memberName + ".php?y=" + AuthConfig.ApiKey + "&z=" + AuthConfig.UserName;
    }
    public RestServiceBase(IAuthConfig config, HttpClient client)
    {
        AuthConfig = config;
        _client = client;
    }
    //protected readonly IHttpService _httpService;

    protected bool AuthRequired { get; set; }

    protected JsonSerializerOptions Options { get; set; } = new JsonSerializerOptions()
    {
        PropertyNameCaseInsensitive = true
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
            }
        }

        //client = (HttpClient)null;
    
        
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