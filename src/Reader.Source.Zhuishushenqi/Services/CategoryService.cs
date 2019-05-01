using Reader.Model.Types;
using Reader.Source.Services;
using Reader.Source.Utilities;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<Categories> GetCategoriesAsync()
        {
            return DefaultHttpUtility.GetAsync<Categories>(Constant.Category);
        }
    }
}
