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
    public class LastChapterInfosServiceTests
    {
        [Test()]
        public async Task GetLastChapterInfosAsyncTestAsync()
        {
            var service = new LastChapterInfosService();
            var chapter = await service.GetLastChapterInfosAsync("5b1739ab4e66e33f75dca017");

            Assert.NotNull(chapter);
        }
    }
}