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
    public class RankingServiceTests
    {
        [Test()]
        public async Task GetRankingGenderAsyncTestAsync()
        {
            var service = new RankingService();
            var rankings = await service.GetRankingGenderAsync();

            Assert.NotNull(rankings);
            Assert.IsTrue(rankings.OK);
        }
    }
}