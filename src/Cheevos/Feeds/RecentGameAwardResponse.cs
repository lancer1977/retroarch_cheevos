namespace PolyhydraGames.RACheevos.Feeds;

public class RecentGameAwardResponse
{
    public int Count { get; set; }
    public int Total { get; set; }
    public List<Result> Results { get; set; }
}