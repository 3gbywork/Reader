using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BooksSearch : Base
    {
        //{
        //    "books": [],
        //    "total": 9,
        //    "ok": true
        //}

        public IList<BookSearch> Books { get; set; }
        public Int32 Total { get; set; }
    }
}
