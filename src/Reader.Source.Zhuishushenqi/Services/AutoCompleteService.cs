using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class AutoCompleteService : IAutoCompleteService
    {
        public Task<AutoComplete> GetAutoCompleteAsync(string keyword)
        {
            var args = new Dictionary<String, String>
            {
                {"query", keyword }
            };
            return DefaultHttpUtility.GetAsync<AutoComplete>(Constant.AutoComplete, args);
        }
    }
}
