using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Json;

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

    //protected List<(string, string)> Wrap(params (string, string)[] items)
    //{
    //    return ((IEnumerable<(string, string)>)items).ToList<(string, string)>();
    //}

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