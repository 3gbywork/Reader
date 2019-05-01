using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class BooksService : IBooksService
    {
        public Task<BooksBrief> GetBooksBriefAsync(String gender, String type, String major, String minor, Int32 start, Int32 limit)
        {
            var args = new Dictionary<String, String>
            {
                {"gender", gender },
                {"type", type },
                {"major", major },
                {"minor", minor },
                {"start", start.ToString() },
                {"limit", limit.ToString() }
            };
            return DefaultHttpUtility.GetAsync<BooksBrief>(Constant.BooksByCategory, args);
        }
    }
}
