namespace PolyhydraGames.RACheevos.Achievements;
public interface IRetroArchAchievementApi
{
    public Task<AchievementUnlocksResponse> GetAchievementUnlocks(int achievementId, int count = 50, int skip= 0);
}