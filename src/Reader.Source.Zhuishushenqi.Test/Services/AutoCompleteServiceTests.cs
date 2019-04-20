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
    public class AutoCompleteServiceTests
    {
        [Test()]
        public async Task GetAutoCompleteAsyncTestAsync()
        {
            const String keyword = "一卡";

            var service = new AutoCompleteService();
            AutoComplete autoComplete = await service.GetAutoCompleteAsync(keyword);

            Assert.NotNull(autoComplete);
            Assert.IsTrue(autoComplete.OK);
            Assert.IsTrue(autoComplete.KeyWords.All(k => k.Contains(keyword)));
        }
    }
}