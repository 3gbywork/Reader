using Reader.Model.Types;
using Reader.Source.Services;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class SearchHotwordService : ISearchHotwordService
    {
        public Task<SearchHotwords> GetSearchHotwordsAsync()
        {
            return DefaultHttpUtility.GetAsync<SearchHotwords>(Constant.SearchHotwords);
        }
    }
}
