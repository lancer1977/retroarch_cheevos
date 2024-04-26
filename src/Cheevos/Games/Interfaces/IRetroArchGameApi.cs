namespace PolyhydraGames.RACheevos; public interface IRetroArchGameApi
{ 
    Task<GetGameResponse> GetGame(int gameID); 
    Task<GetGameExtendedResponse> GetGameExtended(int gameID, bool officialAchievements = false);
    Task<GetAchievementCountResponse> GetAchievementCount(int gameId);
    Task<GetAchievementDistributionResponse> GetAchievementDistribution(int gameId,bool allUnlocks = true, bool officialAchievements = true);
    Task<GetGameRankAndScoreResponse> GetGameRankAndScore(int gameID, bool masters = false);
}