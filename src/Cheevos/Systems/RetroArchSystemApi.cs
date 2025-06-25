namespace PolyhydraGames.RACheevos.Systems;

public class RetroArchSystemApi : RestServiceBase, IRetroArchSystemApi
{
    private List<GameAndHash>? _cache;
    public static List<GameConsole>? ConsolesCache { get; set; }
    public RetroArchSystemApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }
    public async ValueTask<List<GameConsole>> GetConsoleIDs()
    {
        if (ConsolesCache != null && ConsolesCache.Any()) return  ConsolesCache;
        var url = GetBaseUrl();
        var results = await Get<List<GameConsole>>(url);
        if (results != null && results.Any())
        {
            ConsolesCache = results;
        }
        return ConsolesCache ?? new List<GameConsole>();
    }

    public async Task<IEnumerable<GameAndHash>> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false)
    {
        if (_cache != null) return _cache;
        var url = GetBaseUrl().Id(systemId).ParamBool("f", gamesWithAchievementsOnly).ParamBool("h", returnHashes);
        var result = await Get<IEnumerable<GameAndHash>>(url);
        if (result != null && result.Any())
        {
            _cache = result.ToList();
        }
        return _cache;
    }
}