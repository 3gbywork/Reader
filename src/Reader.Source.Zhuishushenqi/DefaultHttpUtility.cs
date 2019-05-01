using Reader.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi
{
    class DefaultHttpUtility
    {
        static private HttpUtility httpClient = new HttpUtility(new ApiClient.ApiClient());

        static public Task<T> GetAsync<T>(String requestUri, IDictionary<String, String> args = null)
        {
            return httpClient.GetAsync<T>(requestUri, args);
        }
    }
}
