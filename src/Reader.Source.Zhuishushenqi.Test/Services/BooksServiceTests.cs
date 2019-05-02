using NUnit.Framework;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services.Tests
{
    [TestFixture()]
    public class BooksServiceTests
    {
        [Test()]
        public async Task GetBooksBriefAsyncTestAsync()
        {
            var service = new BooksService();
            var books = await service.GetBooksBriefAsync("male", "hot", "玄幻", "东方玄幻", 0, 10);

            Assert.NotNull(books);
            Assert.IsTrue(books.OK);
            Assert.AreEqual(books.Books?.Count, 10);
        }
    }
}