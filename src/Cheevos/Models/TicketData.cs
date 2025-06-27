namespace PolyhydraGames.RACheevos.Models;

public class TicketData
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("achievementId")]
    public int? AchievementId { get; set; }

    [JsonPropertyName("openTickets")]
    public int? OpenTickets { get; set; }

    [JsonPropertyName("achievementTitle")]
    public string AchievementTitle { get; set; }

    [JsonPropertyName("achievementDesc")]
    public string AchievementDesc { get; set; }

    [JsonPropertyName("achievementType")]
    public object AchievementType { get; set; }

    [JsonPropertyName("points")]
    public int? Points { get; set; }

    [JsonPropertyName("badgeName")]
    public string BadgeName { get; set; }

    [JsonPropertyName("achievementAuthor")]
    public string AchievementAuthor { get; set; }

    [JsonPropertyName("gameId")]
    public int? GameId { get; set; }

    [JsonPropertyName("consoleName")]
    public string ConsoleName { get; set; }

    [JsonPropertyName("gameTitle")]
    public string GameTitle { get; set; }

    [JsonPropertyName("gameIcon")]
    public string GameIcon { get; set; }

    [JsonPropertyName("reportedAt")]
    public string ReportedAt { get; set; }

    [JsonPropertyName("reportType")]
    public int? ReportType { get; set; }

    [JsonPropertyName("reportState")]
    public int? ReportState { get; set; }

    [JsonPropertyName("hardcore")]
    public object Hardcore { get; set; }

    [JsonPropertyName("reportNotes")]
    public string ReportNotes { get; set; }

    [JsonPropertyName("reportedBy")]
    public string ReportedBy { get; set; }

    [JsonPropertyName("resolvedAt")]
    public string ResolvedAt { get; set; }

    [JsonPropertyName("resolvedBy")]
    public string ResolvedBy { get; set; }

    [JsonPropertyName("reportStateDescription")]
    public string ReportStateDescription { get; set; }

    [JsonPropertyName("reportTypeDescription")]
    public string ReportTypeDescription { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("User")]
    public string User { get; set; }

    [JsonPropertyName("Open")]
    public int? Open { get; set; }

    [JsonPropertyName("Closed")]
    public int? Closed { get; set; }

    [JsonPropertyName("Resolved")]
    public int? Resolved { get; set; }

    [JsonPropertyName("Total")]
    public int? Total { get; set; }

}