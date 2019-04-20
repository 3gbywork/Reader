using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 分类下书籍
    /// </summary>
    public interface IBooksService
    {
        Task<BooksBrief> GetBooksBriefAsync(String gender, String type, String major, String minor, Int32 start, Int32 limit);
    }
}
