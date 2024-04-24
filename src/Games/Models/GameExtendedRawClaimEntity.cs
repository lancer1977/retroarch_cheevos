public interface GameExtendedRawClaimEntity
{
    string User { get; set; }
    string SetType { get; set; }
    GameExtendedClaimType ClaimType { get; set; }
    string Created { get; set; }
    string Expiration { get; set; }
}

 