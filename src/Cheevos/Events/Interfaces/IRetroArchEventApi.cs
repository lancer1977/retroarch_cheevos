public interface IRetroArchEventApi
{
    // https://retroachievements.org/API/API_GetAchievementOfTheWeek.php
    Task<EventResponse> GetAchievementOfTheWeek();
}