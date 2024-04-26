using PolyhydraGames.RACheevos;
using PolyhydraGames.RACheevos.Systems;

namespace Cheevos.Tickets;
public interface IRetroArchTicketApi
{
    Task<TicketData> GetTicketDataById(int id);
    Task<TicketData> GetTicketData(int id, int count = 10, int offset = 0);
    Task<TicketData> GetRecentTicketData(int id, int count = 10, int offset = 0);
    Task<TicketData> GetGameTicketStats(int id); //g=gamdid f for unofficial achievements, d for 1 metadata
    Task<TicketData> GetDeveloperTicketData(string developerUsername); //u=Hexadigital dev username
    Task<TicketData> GetAchievementTicketData(int achievementId); //a=9

}



public class RetroArchTicketApi : RestServiceBase, IRetroArchTicketApi
{
    private List<GameAndHash> _cache;
    public RetroArchTicketApi(IAuthConfig authConfig, HttpClient client) : base(authConfig, client) { }
    public Task<IEnumerable<GameConsole>> GetConsoleIDs()
    {
        var url = GetBaseUrl();
        return Get<IEnumerable<GameConsole>>(url);
    }

    public async Task<IEnumerable<GameAndHash>> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false)
    {
        if (_cache != null) return _cache;
        var url = GetBaseUrl().Id(systemId).ParamBool("f", gamesWithAchievementsOnly).ParamBool("h", returnHashes);
        var result = await Get<IEnumerable<GameAndHash>>(url);
        if (result != null && result.Any()) ;
        {
            _cache = result.ToList();
        }
        return _cache;
    }

    public Task<TicketData> GetTicketDataById(int id)
    {
        var url = GetBaseUrl("GetTicketData").Id(id);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetTicketData(int id, int count = 10, int offset = 0)
    {
        var url = GetBaseUrl("GetTicketData").Id(id);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetRecentTicketData(int id, int count = 10, int offset = 0)
    {
        var url = GetBaseUrl("GetTicketData").Id(id).Count(10).Offset(0);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetGameTicketStats(int id)
    {
        var url = GetBaseUrl("GetTicketData").Id(id);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetDeveloperTicketData(string developerUsername)
    {
        var url = GetBaseUrl("GetTicketData").ParamString("u", developerUsername);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetAchievementTicketData(int achievementId)
    {
        var url = GetBaseUrl("GetTicketData").Id(achievementId);
        return Get<TicketData>(url);
    }
}