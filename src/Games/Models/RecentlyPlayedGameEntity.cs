public interface RecentlyPlayedGameEntity
{
    string GameID { get; set; }
    string ConsoleID { get; set; }
    string ConsoleName { get; set; }
    string Title { get; set; }
    string ImageIcon { get; set; }
    string LastPlayed { get; set; }
}