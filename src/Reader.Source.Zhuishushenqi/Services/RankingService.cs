using Reader.Model.Types;
using Reader.Source.Services;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class RankingService : IRankingService
    {
        public Task<RankingGender> GetRankingGenderAsync()
        {
            return DefaultHttpUtility.GetAsync<RankingGender>(Constant.RankingGender);
        }
    }
}
