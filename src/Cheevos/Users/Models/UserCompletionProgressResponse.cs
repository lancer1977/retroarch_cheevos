namespace PolyhydraGames.RACheevos.Users.Models;
public class UserCompletionProgressResponse
{
    public int Count { get; set; }
    public int Total { get; set; }
    public List<Result> Results { get; set; }
}