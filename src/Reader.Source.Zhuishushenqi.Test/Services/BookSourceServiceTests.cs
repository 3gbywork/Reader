using NUnit.Framework;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services.Tests
{
    [TestFixture()]
    public class BookSourceServiceTests
    {
        [Test()]
        public async Task GetBookSourcesAsyncTestAsync()
        {
            var service = new BookSourceService();
            var source = await service.GetBookSourcesAsync("567d2cb9ee0e56bc713cb2c0");

            Assert.NotNull(source);
        }
    }
}