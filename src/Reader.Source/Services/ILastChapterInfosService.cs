using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 最新章节
    /// </summary>
    public interface ILastChapterInfosService
    {
        Task<LastChapterInfos> GetLastChapterInfosAsync(String bookID);
    }
}
