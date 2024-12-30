namespace PolyhydraGames.RACheevos.Models;
public class RecentGame
{
    public int GameID { get; set; }
    public int ConsoleID { get; set; }
    public string ConsoleName { get; set; }
    public string Title { get; set; }
    public string ImageIcon { get; set; }
    public string ImageTitle { get; set; }
    public string ImageIngame { get; set; }
    public string ImageBoxArt { get; set; }
    public DateTime LastPlayed { get; set; }
    public int AchievementsTotal { get; set; }
    public int NumPossibleAchievements { get; set; }
    public int PossibleScore { get; set; }
    public int NumAchieved { get; set; }
    public int ScoreAchieved { get; set; }
    public int NumAchievedHardcore { get; set; }
    public int ScoreAchievedHardcore { get; set; }
}
public class Game
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("forumTopicId")]
    public int ForumTopicId { get; set; }

    [JsonPropertyName("consoleId")]
    public int ConsoleId { get; set; }

    [JsonPropertyName("consoleName")]
    public string ConsoleName { get; set; }

    [JsonPropertyName("flags")]
    public int Flags { get; set; }

    [JsonPropertyName("imageIcon")]
    public string ImageIcon { get; set; }

    [JsonPropertyName("gameIcon")]
    public string GameIcon { get; set; }

    [JsonPropertyName("imageTitle")]
    public string ImageTitle { get; set; }

    [JsonPropertyName("imageIngame")]
    public string ImageIngame { get; set; }

    [JsonPropertyName("imageBoxArt")]
    public string ImageBoxArt { get; set; }

    [JsonPropertyName("publisher")]
    public string Publisher { get; set; }

    [JsonPropertyName("developer")]
    public string Developer { get; set; }

    [JsonPropertyName("genre")]
    public string Genre { get; set; }

    [JsonPropertyName("released")]
    public string Released { get; set; }

    [JsonPropertyName("gameTitle")]
    public string GameTitle { get; set; }

    [JsonPropertyName("console")]
    public string Console { get; set; }
}