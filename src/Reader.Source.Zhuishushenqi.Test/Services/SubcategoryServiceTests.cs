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
    public class SubcategoryServiceTests
    {
        [Test()]
        public async Task GetSubcategoriesAsyncTestAsync()
        {
            var service = new SubcategoryService();
            var subcat = await service.GetSubcategoriesAsync();

            Assert.NotNull(subcat);
            Assert.IsTrue(subcat.OK);
        }
    }
}