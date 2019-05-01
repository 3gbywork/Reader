using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class SearchService : ISearchService
    {
        public Task<BooksSearch> GetBooksAsync(string keyword)
        {
            var args = new Dictionary<String, String>
            {
                {"query", keyword }
            };
            return DefaultHttpUtility.GetAsync<BooksSearch>(Constant.Search, args);
        }
    }
}
