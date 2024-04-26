
using System.Reflection;

namespace PolyhydraGames.RACheevos.Test;

public class GameTests : BaseTests
{

    public IRetroArchGameApi Api { get; set; }



    public GameTests()
    {
        Api = new RetroArchCheevoApi(Config, new HttpClient());
    }

    [TestCase(9)]
    public async Task GetGame(int gameID)
    {
        var result = await Api.GetGame(gameID);
        Assert.That(result != null);
    }

    [TestCase(9, true)]
    public async Task GetGameExtended(int gameID, bool officialAchievements = false)
    {
        var result = await Api.GetGameExtended(gameID, officialAchievements);
        Assert.That(result != null);
    }
    [TestCase(9)]
    public async Task GetAchievementCount(int gameId)
    {
        var result = await Api.GetAchievementCount(gameId);
        Assert.That(result != null);
    }
    [TestCase(9, true, true)]
    public async Task GetAchievementDistribution(int gameId, bool allUnlocks = true, bool officialAchievements = true)
    {
        var result = await Api.GetAchievementDistribution(gameId, allUnlocks, officialAchievements);
        Assert.That(result != null);
    }
    [TestCase(14402, true)]
    public async Task GetGameRankAndScore(int gameID, bool masters = false)
    {
        var result = await Api.GetGameRankAndScore(gameID, masters);
        Assert.That(result != null);
    }
}