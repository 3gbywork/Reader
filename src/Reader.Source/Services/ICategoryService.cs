﻿using Reader.Model.Types;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 分类
    /// 男生/女生/漫画/出版
    /// </summary>
    public interface ICategoryService
    {
        Task<Categories> GetCategoriesAsync();
    }
}
