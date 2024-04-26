  
namespace PolyhydraGames.RACheevos;
public class RetroArchCheevoApi : RestServiceBase, IRetroArchGameApi
{


    public RetroArchCheevoApi(IAuthConfig authConfig, HttpClient client) : base(authConfig, client)
    {
    }

    public Task<GetGameResponse> GetGame(int gameId)
    {
        var url = GetBaseUrl() + $"&i={gameId}";
        return Get<GetGameResponse>(url);
    }

    public Task<GetGameExtendedResponse> GetGameExtended(int gameId, bool officialAchievements = true)
    {
        var code = officialAchievements ? "3" : "5";
        var url = GetBaseUrl() + $"&i={gameId}&f={code}";
        return Get<GetGameExtendedResponse>(url);
    }

    public Task<GetAchievementCountResponse> GetAchievementCount(int gameId)
    {
        var url = GetBaseUrl() + $"&i={gameId}";
        return Get<GetAchievementCountResponse>(url);
    }

    public Task<GetAchievementDistributionResponse> GetAchievementDistribution(int gameId, bool allUnlocks = true, bool officialAchievements = true)
    {
        var allUnlocksCode = allUnlocks ? "5" : "3";
        var officialAchievementsCode = officialAchievements ? "3" : "5";
        var url = GetBaseUrl() + $"&i={gameId}&h={allUnlocksCode}&f={officialAchievementsCode}";
        return Get<GetAchievementDistributionResponse>(url);
    }

    public Task<GetGameRankAndScoreResponse> GetGameRankAndScore(int gameId, bool masters = false)
    {
        var mastersCode = masters ? "1" : "0";
        var url = GetBaseUrl() + $"&g={gameId}&t={mastersCode}";
        return Get<GetGameRankAndScoreResponse>(url);
    }
}