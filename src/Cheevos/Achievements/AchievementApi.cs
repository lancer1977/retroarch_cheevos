public class AchievementApi : RestServiceBase, IRetroArchAchievementApi
{ 

    public AchievementApi(IAuthConfig authConfig, HttpClient client) : base(authConfig, client)
    { 
    }

    public async Task<AchievementUnlocksResponse> GetAchievementUnlocks(int achievementId,int count, int offset)
    {
        var url = GetBaseUrl( ) + $"&a={achievementId}&c={count}&o={offset}"; 
        return await Get<AchievementUnlocksResponse>(url);
    }
}