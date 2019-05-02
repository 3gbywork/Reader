using NUnit.Framework;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services.Tests
{
    [TestFixture()]
    public class ChapterDetailServiceTests
    {
        [Test()]
        public async Task GetChapterDetailsAsyncTestAsync()
        {
            var service = new ChapterDetailService();
            var chapter = await service.GetChapterDetailsAsync("http://vip.zhuishushenqi.com/chapter/56f8da09176d03ac1983f6e1?cv=1529047156598");

            Assert.NotNull(chapter);
            Assert.IsTrue(chapter.OK);
        }
    }
}