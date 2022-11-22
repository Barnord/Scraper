using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scraper.Core
{
    public class ScraperHtml
    {
        static HttpClient _client = new HttpClient();

        public static async Task<string> HttpRequestAsync(string address)
        {
            if (Uri.IsWellFormedUriString(address, UriKind.Absolute)) {
                _client.BaseAddress = new Uri(address);
            }
            //else
            //{
            //    Uri.
            //}
            //_client.G

            return $"HTTPREQUEST RETURN: {await _client.GetAsync(_client.BaseAddress)}";
        }
    }
}
