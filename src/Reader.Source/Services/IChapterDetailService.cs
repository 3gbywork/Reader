using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 书籍章节内容
    /// </summary>
    public interface IChapterDetailService
    {
        Task<ChapterDetails> GetChapterDetailsAsync(String url);
    }
}
