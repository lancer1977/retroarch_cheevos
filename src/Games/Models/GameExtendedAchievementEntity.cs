public class GameExtendedAchievementEntity
{
    public int Id { get; set; }
    public int NumAwarded { get; set; }
    public int NumAwardedHardcore { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public double TrueRatio { get; set; }
    public string Author { get; set; }
    public string DateModified { get; set; }
    public string DateCreated { get; set; }
    public string BadgeName { get; set; }
    public int DisplayOrder { get; set; }
    public string MemAddr { get; set; }
    public AchievementType Type { get; set; }
}