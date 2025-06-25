namespace PolyhydraGames.RACheevos.Models
{
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
}