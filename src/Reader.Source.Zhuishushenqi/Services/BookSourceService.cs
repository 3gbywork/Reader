using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class BookSourceService : IBookSourceService
    {
        public Task<BookSources> GetBookSourcesAsync(string bookID)
        {
            var args = new Dictionary<String, String>
            {
                {"view", "summary" },
                {"book", bookID }
            };
            return DefaultHttpUtility.GetAsync<BookSources>(Constant.BookSourceA, args);
        }
    }
}
