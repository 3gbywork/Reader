using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 搜索
    /// </summary>
    public interface ISearchService
    {
        Task<BooksSearch> GetBooksAsync(String keyword);
    }
}
