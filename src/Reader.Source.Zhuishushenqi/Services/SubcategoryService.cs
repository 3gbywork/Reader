using Reader.Model.Types;
using Reader.Source.Services;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class SubcategoryService : ISubcategoryService
    {
        public Task<Subcategories> GetSubcategoriesAsync()
        {
            return DefaultHttpUtility.GetAsync<Subcategories>(Constant.Subcategory);
        }
    }
}
