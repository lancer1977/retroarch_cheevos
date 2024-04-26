namespace PolyhydraGames.RACheevos.Systems;
public interface IRetroArchSystemApi
{
    Task<IEnumerable<GameConsole>> GetConsoleIDs();
    Task<IEnumerable<GameAndHash>> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false);
}