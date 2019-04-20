using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 根据书籍获取章节列表
    /// </summary>
    public interface IChapterSummaryService
    {
        Task<ChapterSummary> GetChaptersAsync(String bookID);
    }
}
