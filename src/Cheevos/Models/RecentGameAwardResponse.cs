namespace PolyhydraGames.RACheevos.Models;

public class RecentGameAwardResponse
{
    public int Count { get; set; }
    public int Total { get; set; }
    public List<GameAward> Results { get; set; }
}