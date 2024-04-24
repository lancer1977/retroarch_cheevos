public interface IRetroArchGameApi
{
    Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(int gameID, string userName);
}