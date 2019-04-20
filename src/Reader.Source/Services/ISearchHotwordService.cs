using Reader.Model.Types;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 热搜
    /// </summary>
    public interface ISearchHotwordService
    {
        Task<SearchHotwords> GetSearchHotwordsAsync();
    }
}
