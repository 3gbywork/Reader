﻿using Reader.Model.Types;
using Reader.Source.Services;
using Reader.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return HttpUtility.GetAsync<BookSources>(Constant.BookSourceA, args);
        }
    }
}