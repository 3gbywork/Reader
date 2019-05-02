using NUnit.Framework;
using Reader.Model.Types;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services.Tests
{
    [TestFixture()]
    public class CategoryServiceTests
    {
        [Test()]
        public async Task GetCategoriesAsyncTestAsync()
        {
            var service = new CategoryService();
            Categories cat = await service.GetCategoriesAsync();

            Assert.NotNull(cat);
            Assert.IsTrue(cat.OK);
        }
    }
}