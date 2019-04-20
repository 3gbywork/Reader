using Reader.Model.Types;
using System.Threading;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 子分类
    /// 分类下子分类
    /// </summary>
    public interface ISubcategoryService
    {
        Task<Subcategories> GetSubcategoriesAsync();
    }
}
