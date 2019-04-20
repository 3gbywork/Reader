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
    public class SearchHotwordServiceTests
    {
        [Test()]
        public async Task GetSearchHotwordsAsyncTestAsync()
        {
            var service = new SearchHotwordService();
            var hotwords = await service.GetSearchHotwordsAsync();

            Assert.NotNull(hotwords);
            Assert.IsTrue(hotwords.OK);
        }
    }
}