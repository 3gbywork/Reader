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
    public class SearchHotwordService : ISearchHotwordService
    {
        public Task<SearchHotwords> GetSearchHotwordsAsync()
        {
            return HttpUtility.GetAsync<SearchHotwords>(Constant.SearchHotwords);
        }
    }
}
