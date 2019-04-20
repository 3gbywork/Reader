using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 根据书源获取章节列表
    /// </summary>
    public interface IChapterSummaryExService
    {
        Task<ChapterSummaryEx> GetChapterSummaryExAsync(String sourceID);
    }
}
