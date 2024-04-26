namespace PolyhydraGames.RACheevos;
public class AchievementUnlocksMetadata
{
    AchievementMetadata Achievement { get; set; }
    ConsoleMetadata Console { get; set; }
    GameMetadata Game { get; set; }
    int UnlocksCount { get; set; }
    int TotalPlayers { get; set; }
    List<AchievementUnlock> Unlocks { get; set; }
}