public class GetGameExtendedResponse
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int ConsoleID { get; set; }
    public int ForumTopicID { get; set; }
    public int Flags { get; set; }
    public string ImageIcon { get; set; }
    public string ImageTitle { get; set; }
    public string ImageIngame { get; set; }
    public string ImageBoxArt { get; set; }
    public string Publisher { get; set; }
    public string Developer { get; set; }
    public string Genre { get; set; }
    public string Released { get; set; }
    public bool IsFinal { get; set; }
    public string ConsoleName { get; set; }
    public string RichPresencePatch { get; set; }
    public int NumAchievements { get; set; }
    public string NumDistinctPlayersCasual { get; set; }
    public string NumDistinctPlayersHardcore { get; set; }
    public List<GameExtendedRawClaimEntity> Claims { get; set; }
    public Dictionary<int, GameExtendedRawAchievementEntity> Achievements { get; set; }
}