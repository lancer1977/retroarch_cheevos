namespace PolyhydraGames.RACheevos;
public interface IRetroArchEventApi
{ 
    Task<EventResponse> GetAchievementOfTheWeek();
}