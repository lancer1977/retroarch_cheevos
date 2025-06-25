using PolyhydraGames.RACheevos.Games.Responses;

namespace PolyhydraGames.RACheevos.Games.Interfaces; public interface IRetroArchGameApi
{
    ValueTask<GetGameResponse> GetGame(int gameID);
    Task<GetGameExtendedResponse> GetGameExtended(int gameID, bool officialAchievements = false);
    Task<GetAchievementCountResponse> GetAchievementCount(int gameId);
    Task<GetAchievementDistributionResponse> GetAchievementDistribution(int gameId, bool allUnlocks = true, bool officialAchievements = true);
    Task<GetGameRankAndScoreResponse> GetGameRankAndScore(int gameID, bool masters = false);
}