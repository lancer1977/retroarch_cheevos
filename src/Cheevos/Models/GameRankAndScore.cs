namespace PolyhydraGames.RACheevos.Models;
public class GameRankAndScore
{
    public string User { get; set; }
    public string ULID { get; set; }
    public int NumAchievements { get; set; }
    public int TotalScore { get; set; }
    public string LastAward { get; set; } 
}