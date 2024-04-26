using PolyhydraGames.RACheevos.Systems; 

namespace PolyhydraGames.RACheevos.Feeds;

public class RetroArchSystemApi : RestServiceBase, IRetroArchSystemApi
{
    private List<GameAndHash> _cache;
    public RetroArchSystemApi(IAuthConfig authConfig, HttpClient client) : base(authConfig, client) { }
    public Task<IEnumerable<GameConsole>> GetConsoleIDs()
    {
        var url = GetBaseUrl();
        return Get<IEnumerable<GameConsole>>(url);
    }
    
    public async Task<IEnumerable<GameAndHash>> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false )
    {
        if (_cache != null) return _cache;
        var url = GetBaseUrl().Id(systemId).ParamBool("f",gamesWithAchievementsOnly).ParamBool("h",returnHashes);
        var result = await Get<IEnumerable<GameAndHash>>(url);
        if (result != null && result.Any()) ;
        {
            _cache = result.ToList();
        }
        return _cache;
    }
}