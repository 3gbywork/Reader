using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    /// <summary>
    /// auto-complete
    /// </summary>
    public class AutoComplete : Base
    {
        public IList<String> KeyWords { get; set; }
    }
}
