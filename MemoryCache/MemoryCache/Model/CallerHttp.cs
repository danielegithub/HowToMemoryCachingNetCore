using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemoryCache.Model;
using System.Net.Http;
using RestSharp;
namespace MemoryCache.Model
{
    public class CallerHttp
    {
        private string BaseAddress => "/";
        static HttpClient client = new HttpClient();

        public static List<Stati> GetStati()
        {
            var client = new RestClient("https://restcountries.eu/rest/v2");

            var request = new RestRequest("region/europe", DataFormat.Json);

            var stati = client.Get<List<Stati>>(request);
            return stati.Data;
        }
    }
}
