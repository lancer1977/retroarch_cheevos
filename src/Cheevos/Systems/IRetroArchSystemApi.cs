namespace PolyhydraGames.RACheevos.Systems;
public interface IRetroArchSystemApi
{
    ValueTask<List<GameConsole>> GetConsoleIDs();
    Task<IEnumerable<GameAndHash>> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false);
}