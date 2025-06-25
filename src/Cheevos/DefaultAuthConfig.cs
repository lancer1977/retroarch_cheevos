namespace PolyhydraGames.RACheevos;
public class DefaultAuthConfig : ICheevoAuth
{
    public bool Authorized => string.IsNullOrEmpty(ApiKey);

    public string ApiKey { get; set; }
    public string UserName { get; set; }
}