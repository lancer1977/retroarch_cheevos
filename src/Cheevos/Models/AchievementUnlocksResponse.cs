namespace PolyhydraGames.RACheevos.Models;
public class AchievementUnlocksResponse
{
    public AchievementUnlocks Achievement { get; set; }
    public GameConsole Console { get; set; }
    public Game Game { get; set; }
    public int UnlocksCount { get; set; }
    public int UnlocksHardcoreCount { get; set; }
    public int TotalPlayers { get; set; }
    public List<Unlock> Unlocks { get; set; }
}