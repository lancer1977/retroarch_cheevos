namespace PolyhydraGames.RACheevos;
public class RankedUser
{
    [JsonPropertyName("1")]
    public string Name { get; set; }

    [JsonPropertyName("2")]
    public int HardcorePoints { get; set; }

    [JsonPropertyName("3")]
    public int RetroPoints { get; set; }
}