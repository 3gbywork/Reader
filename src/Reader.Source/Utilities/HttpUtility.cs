using Reader.Source.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.Utilities
{
    public static class HttpUtility
    {
        private static IApiClient client;

        static HttpUtility()
        {
            client = new ApiClient.ApiClient();
        }

        public static Task<T> GetAsync<T>(String requestUri)
        {
            return client.GetAsync<T>(requestUri);
        }

        public static Task<T> GetAsync<T>(String requestUri, IDictionary<String, String> args)
        {
            return client.GetAsync<T>(requestUri, args);
        }
    }
}
