 

namespace PolyhydraGames.RACheevos;
public class EventApi : RestServiceBase, IRetroArchEventApi
{ 

    public EventApi(IAuthConfig authConfig, HttpClient client) : base(authConfig, client)
    { 
    }


    public Task<EventResponse> GetAchievementOfTheWeek()
    {
        var url = GetBaseUrl()  ;
        return Get<EventResponse>(url);
    }
}
 