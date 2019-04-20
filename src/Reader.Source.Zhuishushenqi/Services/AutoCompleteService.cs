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
    public class AutoCompleteService : IAutoCompleteService
    {
        public Task<AutoComplete> GetAutoCompleteAsync(string keyword)
        {
            var args = new Dictionary<String, String>
            {
                {"query", keyword }
            };
            return HttpUtility.GetAsync<AutoComplete>(Constant.AutoComplete, args);
        }
    }
}