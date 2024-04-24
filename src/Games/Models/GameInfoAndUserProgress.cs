public class GameInfoAndUserProgress : GameExtended
{
    public Dictionary<int, GameExtendedAchievementEntityWithUserProgress> Achievements { get; set; }

    public int NumAwardedToUser { get; set; }
    public int NumAwardedToUserHardcore { get; set; }
    public string UserCompletion { get; set; }
    public string UserCompletionHardcore { get; set; }
}