using NUnit.Framework;
using Reader.Model.Types;
using Reader.Source.Zhuishushenqi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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