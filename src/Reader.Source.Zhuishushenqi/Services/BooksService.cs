using Reader.Model.Types;
using Reader.Source.Services;
using Reader.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return HttpUtility.GetAsync<BooksBrief>(Constant.BooksByCategory, args);
        }
    }
}
