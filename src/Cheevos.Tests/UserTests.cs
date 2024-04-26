using System;
namespace PolyhydraGames.RACheevos.Test;
public class UserTests : BaseTests
{
    private IRetroArchUserApi Api { get; set; }

    public UserTests()
    {
        Api = new RetroArchUserApi(Config, new HttpClient());
    }

    [Test]
    public async Task GetUserProfile()
    {
        var result = await Api.GetUserProfile(base.TestUser);
        Assert.That(result.User == TestUser);
    }

    [Test]
    public async Task GetUserRecentAchievements()
    {
        var result = await Api.GetUserRecentAchievements(base.TestUser, 100011);
        Assert.That(result.Any());
    }



    [Test]
    public async Task GetAchievementsEarnedBetween()
    {
        var now = DateTime.Now;
        DateTime start = now - TimeSpan.FromDays(1000);
        DateTime end = now;

        var result = await Api.GetAchievementsEarnedBetween(TestUser, start, end);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetAchievementsEarnedOnDay()
    {
        var day = DateTime.Now;
        var result = await Api.GetAchievementsEarnedOnDay(TestUser, day);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetGameInfoAndUserProgress()
    {
        var result = await Api.GetGameInfoAndUserProgress(TestUser, TestGameId);
    }
    [Test]
    public async Task GetUserCompletionProgress()
    {
        var result = await Api.GetUserCompletionProgress(TestUser);
        Assert.That(result.Total > 0);
    }
    [Test]
    public async Task GetUserAwards()
    {
        var result = await Api.GetUserAwards(TestUser);
        Assert.That(result.TotalAwardsCount > 0);
    }
    [Test]
    public async Task GetUserClaims()
    {
        var result = await Api.GetUserClaims(TestUser);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetUserGameRankAndScore()
    {
        var result = await Api.GetUserGameRankAndScore(TestUser, TestGameId);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetUserPoints()
    {
        var result = await Api.GetUserPoints(TestUser);
        Assert.That(result.Points > 0);
    }

    [Test]
    public async Task GetUserProgress()
    {
        IEnumerable<int> achievementIds = new List<int> { 1, 2, 3 };
        var result = await Api.GetUserProgress(TestUser, achievementIds);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetUserRecentlyPlayedGames()
    {
        var result = await Api.GetUserRecentlyPlayedGames(TestUser);
        Assert.That(result.Any());
    }

    [Test]
    public async Task GetUserSummary()
    {
        var result = await Api.GetUserSummary(TestUser);
        Assert.That(result.Rank > 0);
    }

    [Test]
    public async Task GetUserCompletedGames()
    {
        var result = await Api.GetUserCompletedGames(TestUser);

    }
}
