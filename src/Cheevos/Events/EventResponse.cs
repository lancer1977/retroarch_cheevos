namespace PolyhydraGames.RACheevos.Events;
public class EventResponse
{
    public Achievement Achievement { get; set; }
    public GameConsole Console { get; set; }
    public ForumTopic ForumTopic { get; set; }
    public Game Game { get; set; }
    public DateTime StartAt { get; set; }
    public int TotalPlayers { get; set; }
    public List<Unlock> Unlocks { get; set; }
    public int UnlocksCount { get; set; }
    public int UnlocksHardcoreCount { get; set; }
}