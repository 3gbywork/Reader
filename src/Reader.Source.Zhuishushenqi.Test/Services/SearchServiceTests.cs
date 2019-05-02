using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services.Tests
{
    [TestFixture()]
    public class SearchServiceTests
    {
        [Test()]
        public async Task GetBooksAsyncTestAsync()
        {
            const String keyword = "一卡";

            var service = new SearchService();
            var books = await service.GetBooksAsync(keyword);

            Assert.NotNull(books);
            Assert.IsTrue(books.OK);
        }
    }
}