namespace PolyhydraGames.RACheevos.Events;
public interface IRetroArchEventApi
{
    Task<EventResponse> GetAchievementOfTheWeek();
}