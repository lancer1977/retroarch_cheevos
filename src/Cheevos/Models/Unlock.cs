public class Unlock
{
    public string User { get; set; }
    public int RAPoints { get; set; }
    public DateTime DateAwarded { get; set; }
    public int HardcoreMode { get; set; }
}

public class RankedUser
{
    [JsonPropertyName("1")]
    public string Name { get; set; }

    [JsonPropertyName("2")]
    public int HardcorePoints { get; set; }

    [JsonPropertyName("3")]
    public int RetroPoints { get; set; }
}