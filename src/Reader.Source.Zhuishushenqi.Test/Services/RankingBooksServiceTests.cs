using NUnit.Framework;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services.Tests
{
    [TestFixture()]
    public class RankingBooksServiceTests
    {
        [Test()]
        public async Task GetRankingBooksAsyncTestAsync()
        {
            var service = new RankingBooksService();
            var books = await service.GetRankingBooksAsync("54d42d92321052167dfb75e3");

            Assert.NotNull(books);
            Assert.IsTrue(books.OK);
        }
    }
}