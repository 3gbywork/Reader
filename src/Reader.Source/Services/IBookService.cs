using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 书籍详情
    /// </summary>
    public interface IBookService
    {
        Task<BookDetails> GetBookDetailsAsync(String bookID);
    }
}
