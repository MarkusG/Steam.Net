using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace Steam
{
    public static class WebHelper
    {
        public static async Task<string> DownloadStringAsync(string uri)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);
            var content = response.Content;
            string result = await content.ReadAsStringAsync();
            client.Dispose();
            response.Dispose();
            content.Dispose();
            return result;
        }
    }
}
