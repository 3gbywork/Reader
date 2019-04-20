using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BooksBrief : Base
    {
        //{
        //    "books": [],
        //    "total": 9,
        //    "ok": true
        //}

        public IList<BookBrief> Books { get; set; }
        public Int32 Total { get; set; }
    }
}
