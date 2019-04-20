using Reader.Model.Types;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Services
{
    /// <summary>
    /// 自动完成
    /// </summary>
    public interface IAutoCompleteService
    {
        Task<AutoComplete> GetAutoCompleteAsync(String keyword);
    }
}
