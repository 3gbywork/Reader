using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 书源
    /// </summary>
    public interface IBookSourceService
    {
        Task<BookSources> GetBookSourcesAsync(String bookID);
    }
}
