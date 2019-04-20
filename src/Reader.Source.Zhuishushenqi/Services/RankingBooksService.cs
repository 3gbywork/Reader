using Reader.Model.Types;
using Reader.Source.Services;
using Reader.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class RankingBooksService : IRankingBooksService
    {
        public Task<RankingBooks> GetRankingBooksAsync(string rankingID)
        {
            return HttpUtility.GetAsync<RankingBooks>($"{Constant.BooksByRanking}/{rankingID}");
        }
    }
}
