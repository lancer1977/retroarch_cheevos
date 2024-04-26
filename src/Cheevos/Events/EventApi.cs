 

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

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
//public class Achievement
//{
//    public int ID { get; set; }
//    public string Title { get; set; }
//    public string Description { get; set; }
//    public int Points { get; set; }
//    public int TrueRatio { get; set; }
//    public object Type { get; set; }
//    public string Author { get; set; }
//    public string DateCreated { get; set; }
//    public string DateModified { get; set; }
//}

//public class Console
//{
//    public int ID { get; set; }
//    public string Title { get; set; }
//}

//public class Game
//{
//    public int ID { get; set; }
//    public string Title { get; set; }
//}

//public class Unlock
//{
//    public string User { get; set; }
//    public int RAPoints { get; set; }
//    public DateTime DateAwarded { get; set; }
//    public int HardcoreMode { get; set; }
//}

