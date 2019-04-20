using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.ApiClient
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(String requestUri);
        Task<T> GetAsync<T>(String requestUri, IDictionary<String, String> args);
    }
}
