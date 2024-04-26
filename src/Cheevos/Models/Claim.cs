namespace PolyhydraGames.RACheevos;
public class Claim
{
    public string User { get; set; }
    public int SetType { get; set; }
    public int GameID { get; set; }
    public int ClaimType { get; set; }
    public string Created { get; set; }
    public string Expiration { get; set; }
}

// Assuming GameExtended and GameExtendedAchievementEntity are already defined elsewhere