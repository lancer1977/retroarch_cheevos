namespace PolyhydraGames.RACheevos.Models;
public class RecentlyPlayed
{
    public int GameID { get; set; }
    public int ConsoleID { get; set; }
    public string ConsoleName { get; set; }
    public string Title { get; set; }
    public string ImageIcon { get; set; }
    public string ImageTitle { get; set; }
    public string ImageIngame { get; set; }
    public string ImageBoxArt { get; set; }
    public string LastPlayed { get; set; }
    public int AchievementsTotal { get; set; }
}