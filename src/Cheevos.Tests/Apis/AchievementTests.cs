using PolyhydraGames.RACheevos.Achievements;

namespace PolyhydraGames.RACheevos.Test.Apis;
public class AchievementTests : BaseTests
{
    public IRetroArchAchievementApi Api { get; set; }
    [SetUp]
    public void Setup()
    {
        Api = new AchievementApi(Config, new HttpClient());
    }



    [TestCase(9)]
    public async Task GetAchievementUnlocks(int id)
    {
        var result = await Api.GetAchievementUnlocks(id);
        Assert.That(result != null);
    }


}