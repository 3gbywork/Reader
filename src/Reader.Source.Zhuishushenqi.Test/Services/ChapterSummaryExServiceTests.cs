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
    public class ChapterSummaryExServiceTests
    {
        [Test()]
        public async Task GetChapterSummaryExAsyncTestAsync()
        {
            var service = new ChapterSummaryExService();
            var chapter = await service.GetChapterSummaryExAsync("579b93b0561763dd2d2382ea");

            Assert.NotNull(chapter);
        }
    }
}