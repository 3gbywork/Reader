using Reader.Source.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.Utilities
{
    public class HttpUtility
    {
        private IApiClient client;

        public HttpUtility(IApiClient apiClient)
        {
            client = apiClient;
        }

        public Task<T> GetAsync<T>(String requestUri)
        {
            return client.GetAsync<T>(requestUri);
        }

        public Task<T> GetAsync<T>(String requestUri, IDictionary<String, String> args)
        {
            return client.GetAsync<T>(requestUri, args);
        }
    }
}
