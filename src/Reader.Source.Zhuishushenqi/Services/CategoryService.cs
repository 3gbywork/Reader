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
    public class CategoryService : ICategoryService
    {
        public Task<Categories> GetCategoriesAsync()
        {
            return HttpUtility.GetAsync<Categories>(Constant.Category);
        }
    }
}
