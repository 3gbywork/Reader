using Reader.Model.Types;
using Reader.Source.Services;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class RankingBooksService : IRankingBooksService
    {
        public Task<RankingBooks> GetRankingBooksAsync(string rankingID)
        {
            return DefaultHttpUtility.GetAsync<RankingBooks>($"{Constant.BooksByRanking}/{rankingID}");
        }
    }
}
