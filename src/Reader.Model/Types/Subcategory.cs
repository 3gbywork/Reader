using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class Subcategory
    {
        public String Major { get; set; }
        public IList<String> Mins { get; set; }
    }
}
