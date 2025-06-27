namespace PolyhydraGames.RACheevos.Games;
public class RetroArchCheevoApi : RestServiceBase, IRetroArchGameApi
{
    public Dictionary<int, Game> GameCache = new();

    public RetroArchCheevoApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client)
    {
    }

    public async ValueTask<Game> GetGame(int gameId)
    {
        if (GameCache.TryGetValue(gameId, out var game))
            return game;
        var url = GetBaseUrl().Id(gameId);
        var result = await Get<Game>(url);
        if (result != null && !string.IsNullOrEmpty(result.Title))
            GameCache[gameId] = result;
        return result;
    }

    public Task<GetGameExtendedResponse> GetGameExtended(int gameId, bool officialAchievements = true)
    { 
        var url = GetBaseUrl().Id(gameId).OfficialOnly(officialAchievements);
        return Get<GetGameExtendedResponse>(url);
    }

    public Task<HashResponse> GetGameHashes(int gameId )
    {
        var url = GetBaseUrl().Id(gameId);
        return Get<HashResponse>(url);
    }

    public Task<GetAchievementCountResponse> GetAchievementCount(int gameId)
    {
        var url = GetBaseUrl().Id(gameId);
        return Get<GetAchievementCountResponse>(url);
    }

    public Task<GetAchievementDistributionResponse> GetAchievementDistribution(int gameId, bool hardcoreOnly = true, bool officialAchievements = true)
    { 
        var url = GetBaseUrl().Id(gameId).H(hardcoreOnly).OfficialOnly(officialAchievements);
        return Get<GetAchievementDistributionResponse>(url);
    }

    public Task<GetGameRankAndScoreResponse> GetGameRankAndScore(int gameId, bool masters = false)
    {
        var url = GetBaseUrl().GameID(gameId).Masters(masters);
        return Get<GetGameRankAndScoreResponse>(url);
    }
}