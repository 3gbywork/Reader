using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.ApiClient.Http
{
    public interface IHttp
    {
        Task<String> GetAsync(String requestUri, IDictionary<String, String> args);
    }
}
