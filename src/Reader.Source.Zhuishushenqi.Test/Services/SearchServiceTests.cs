using NUnit.Framework;
using Reader.Source.Zhuishushenqi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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