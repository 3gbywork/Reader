using Reader.Model.Types;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 排行榜榜单
    /// </summary>
    public interface IRankingService
    {
        Task<RankingGender> GetRankingGenderAsync();
    }
}
