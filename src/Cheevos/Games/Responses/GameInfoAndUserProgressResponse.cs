public class GameInfoAndUserProgressResponse
{
    public string User { get; set; }
    public string MemberSince { get; set; }
    public LastActivity LastActivity { get; set; }
    public string RichPresenceMsg { get; set; }
    public int LastGameID { get; set; }
    public int ContribCount { get; set; }
    public int ContribYield { get; set; }
    public int TotalPoints { get; set; }
    public int TotalSoftcorePoints { get; set; }
    public int TotalTruePoints { get; set; }
    public int Permissions { get; set; }
    public int Untracked { get; set; }
    public int ID { get; set; }
    public int UserWallActive { get; set; }
    public string Motto { get; set; }
    public int Rank { get; set; }
    public int RecentlyPlayedCount { get; set; }
    public List<RecentlyPlayed> RecentlyPlayed { get; set; }
    public Dictionary<int,Achievement> Awarded { get; set; }
    //public RecentAchievements RecentAchievements { get; set; }
    public LastGame LastGame { get; set; }
    public string UserPic { get; set; }
    public int TotalRanked { get; set; }
    public string Status { get; set; }
}