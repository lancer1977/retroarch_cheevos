
using PolyhydraGames.RACheevos.Games.Interfaces;
using PolyhydraGames.RACheevos.Games.Responses;

namespace PolyhydraGames.RACheevos.Games;
public class RetroArchCheevoApi : RestServiceBase, IRetroArchGameApi
{
    public Dictionary<int, GetGameResponse> GameCache = new();

    public RetroArchCheevoApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client)
    {
    }

    public async ValueTask<GetGameResponse> GetGame(int gameId)
    {
        if (GameCache.TryGetValue(gameId, out var game))
            return game;
        var url = GetBaseUrl().Id(gameId);
        var result = await Get<GetGameResponse>(url);
        if (result != null && !string.IsNullOrEmpty(result.Title))
            GameCache[gameId] = result;
        return result;
    }

    public Task<GetGameExtendedResponse> GetGameExtended(int gameId, bool officialAchievements = true)
    {
        var code = officialAchievements ? "3" : "5";
        var url = GetBaseUrl().Id(gameId).ParamString("f", code);
        return Get<GetGameExtendedResponse>(url);
    }

    public Task<GetAchievementCountResponse> GetAchievementCount(int gameId)
    {
        var url = GetBaseUrl().Id(gameId);
        return Get<GetAchievementCountResponse>(url);
    }

    public Task<GetAchievementDistributionResponse> GetAchievementDistribution(int gameId, bool allUnlocks = true, bool officialAchievements = true)
    { 
        var url = GetBaseUrl().Id(gameId).H(allUnlocks).OfficialOnly(officialAchievements);
        return Get<GetAchievementDistributionResponse>(url);
    }

    public Task<GetGameRankAndScoreResponse> GetGameRankAndScore(int gameId, bool masters = false)
    {
        var mastersCode = 
        var url = GetBaseUrl().GameID(gameId) + $"&g={gameId}&t={mastersCode}";
        return Get<GetGameRankAndScoreResponse>(url);
    }
}