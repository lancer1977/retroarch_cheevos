

//public static cl
public class RetroArchCheevoApi : RestServiceBase, IRetroArchGameApi
{
  

    public RetroArchCheevoApi(IAuthConfig authConfig, HttpClient client):base(authConfig,client)
    { 
    }


    public   Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(int gameID, string userName)
    {
        var url = GetBaseUrl() + $"&u={userName}";//&f={start.ToEpoch()}&t={end.ToEpoch()}";
        return Get<GameInfoAndUserProgressResponse>(url);
    }
}