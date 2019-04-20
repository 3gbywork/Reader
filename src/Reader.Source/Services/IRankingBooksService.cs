using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 根据排行榜分类获取书籍
    /// </summary>
    public interface IRankingBooksService
    {
        Task<RankingBooks> GetRankingBooksAsync(String rankingID);
    }
}
