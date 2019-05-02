using NUnit.Framework;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services.Tests
{
    [TestFixture()]
    public class ChapterSummaryServiceTests
    {
        [Test()]
        public async Task GetChaptersAsyncTestAsync()
        {
            var service = new ChapterSummaryService();
            var chapter = await service.GetChaptersAsync("567d2cb9ee0e56bc713cb2c0");

            Assert.NotNull(chapter);
            Assert.IsTrue(chapter.OK);
        }
    }
}