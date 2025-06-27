namespace PolyhydraGames.RACheevos.Achievements;

public class AchievementApi : RestServiceBase, IRetroArchAchievementApi
{
    public AchievementApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }

    public async Task<AchievementUnlocksResponse?> GetAchievementUnlocks(int achievementId, int count = 50, int offset = 0)
    {
        var url = GetBaseUrl().A(achievementId).Offset(offset).Count(count);
        return await Get<AchievementUnlocksResponse>(url);
    }
}
#if NET6_0_OR_GREATER
public record Achievement(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("Points")] int Points,
    [property: JsonPropertyName("TrueRatio")] int TrueRatio,
    [property: JsonPropertyName("Author")] string Author,
    [property: JsonPropertyName("AuthorULID")] string AuthorULID,
    [property: JsonPropertyName("DateCreated")] string DateCreated,
    [property: JsonPropertyName("DateModified")] string DateModified,
    [property: JsonPropertyName("Type")] string Type
);

public record Console(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title
);

public record Game(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title
);

public record AchievementUnlocksResponse(
    [property: JsonPropertyName("Achievement")] Achievement Achievement,
    [property: JsonPropertyName("Console")] Console Console,
    [property: JsonPropertyName("Game")] Game Game,
    [property: JsonPropertyName("UnlocksCount")] int UnlocksCount,
    [property: JsonPropertyName("UnlocksHardcoreCount")] int UnlocksHardcoreCount,
    [property: JsonPropertyName("TotalPlayers")] int TotalPlayers,
    [property: JsonPropertyName("Unlocks")] IReadOnlyList<Unlock> Unlocks
);

public record Unlock(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("RAPoints")] int RAPoints,
    [property: JsonPropertyName("RASoftcorePoints")] int RASoftcorePoints,
    [property: JsonPropertyName("DateAwarded")] DateTime DateAwarded,
    [property: JsonPropertyName("HardcoreMode")] int HardcoreMode
);
#else
 public class Achievement
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Points")]
        public int Points { get; set; }

        [JsonPropertyName("TrueRatio")]
        public int TrueRatio { get; set; }

        [JsonPropertyName("Author")]
        public string Author { get; set; }

        [JsonPropertyName("AuthorULID")]
        public string AuthorULID { get; set; }

        [JsonPropertyName("DateCreated")]
        public string DateCreated { get; set; }

        [JsonPropertyName("DateModified")]
        public string DateModified { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }
    }

    public class Console
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }
    }

    public class Game
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }
    }

    public class AchievementUnlocksResponse
    {
        [JsonPropertyName("Achievement")]
        public Achievement Achievement { get; set; }

        [JsonPropertyName("Console")]
        public Console Console { get; set; }

        [JsonPropertyName("Game")]
        public Game Game { get; set; }

        [JsonPropertyName("UnlocksCount")]
        public int UnlocksCount { get; set; }

        [JsonPropertyName("UnlocksHardcoreCount")]
        public int UnlocksHardcoreCount { get; set; }

        [JsonPropertyName("TotalPlayers")]
        public int TotalPlayers { get; set; }

        [JsonPropertyName("Unlocks")]
        public List<Unlock> Unlocks { get; set; }
    }

    public class Unlock
    {
        [JsonPropertyName("User")]
        public string User { get; set; }

        [JsonPropertyName("ULID")]
        public string ULID { get; set; }

        [JsonPropertyName("RAPoints")]
        public int RAPoints { get; set; }

        [JsonPropertyName("RASoftcorePoints")]
        public int RASoftcorePoints { get; set; }

        [JsonPropertyName("DateAwarded")]
        public DateTime DateAwarded { get; set; }

        [JsonPropertyName("HardcoreMode")]
        public int HardcoreMode { get; set; }
    }

#endif