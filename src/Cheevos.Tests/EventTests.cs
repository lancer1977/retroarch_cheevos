using System.Diagnostics;

namespace PolyhydraGames.RACheevos.Test
{
    public class EventTests : BaseTests
    {
        public IRetroArchEventApi Api { get; set; }
        [SetUp]
        public void Setup()
        {
            Api = new EventApi(Config, new HttpClient());
        }



        [Test]
        public async Task GetAchievementUnlocks()
        {
            var result = await Api.GetAchievementOfTheWeek();
            Trace.WriteLine(result.Game.Title);
            System.Console.WriteLine($"Event was:{result.Game.Title}");
            Assert.That(result != null);
        }


    }
}