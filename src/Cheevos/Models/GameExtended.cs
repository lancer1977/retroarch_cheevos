public class GameExtended
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("consoleId")]
    public int ConsoleId { get; set; }

    [JsonPropertyName("forumTopicId")]
    public int ForumTopicId { get; set; }

    [JsonPropertyName("flags")]
    public int Flags { get; set; }

    [JsonPropertyName("imageIcon")]
    public string ImageIcon { get; set; }

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

    [JsonPropertyName("isFinal")]
    public bool IsFinal { get; set; }

    [JsonPropertyName("consoleName")]
    public string ConsoleName { get; set; }

    [JsonPropertyName("richPresencePatch")]
    public string RichPresencePatch { get; set; }

    [JsonPropertyName("numAchievements")]
    public int NumAchievements { get; set; }

    [JsonPropertyName("numDistinctPlayersCasual")]
    public int NumDistinctPlayersCasual { get; set; }

    [JsonPropertyName("numDistinctPlayersHardcore")]
    public int NumDistinctPlayersHardcore { get; set; }

    [JsonPropertyName("claims")]
    public List<Claim> Claims { get; set; }

    [JsonPropertyName("achievements")]
    public Dictionary<int, GameExtendedAchievement> Achievements { get; set; }
}

//public class GameExtendedClaimEntity
//{
//    // Define properties for GameExtendedClaimEntity if needed
//}

//public class GameExtendedAchievementEntity
//{
//    // Define properties for GameExtendedAchievementEntity if needed
//}
