namespace PolyhydraGames.RACheevos.Models;
public class GameExtendedRawAchievementEntity
{
    public int ID { get; set; }
    public int NumAwarded { get; set; }
    public int NumAwardedHardcore { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public int TrueRatio { get; set; }
    public string Author { get; set; }
    public string DateModified { get; set; }
    public string DateCreated { get; set; }
    public string BadgeName { get; set; }
    public int DisplayOrder { get; set; }
    public string MemAddr { get; set; }
    public object type { get; set; }
}