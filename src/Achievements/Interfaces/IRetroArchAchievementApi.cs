public interface IRetroArchAchievementApi
{
    public Task<AchievementUnlocksResponse> GetAchievementUnlocks(string achievementId, int count = 50, int skip= 0);
}