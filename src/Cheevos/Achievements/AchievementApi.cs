namespace PolyhydraGames.RACheevos;

public class AchievementApi : RestServiceBase, IRetroArchAchievementApi
{ 

    public AchievementApi(IAuthConfig authConfig, HttpClient client) : base(authConfig, client)
    { 
    }

    public async Task<AchievementUnlocksResponse> GetAchievementUnlocks(int achievementId,int count = 50, int offset = 0)
    {
        var url = GetBaseUrl() + $"&a={achievementId}".Offset(offset).Count(count);
        return await Get<AchievementUnlocksResponse>(url);
    }
}