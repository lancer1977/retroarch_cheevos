public interface RecentlyAwardedAchievementEntity
{
    string NumPossibleAchievements { get; set; }
    string PossibleScore { get; set; }
    object NumAchieved { get; set; }
    object ScoreAchieved { get; set; }
    object NumAchievedHardcore { get; set; }
    object ScoreAchievedHardcore { get; set; }
}