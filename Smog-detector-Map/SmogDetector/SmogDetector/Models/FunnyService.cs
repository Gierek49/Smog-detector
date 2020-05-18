using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Giphy
{
    public class GpihyServices
    {
        private RestClient client =
            new RestClient("http://api.giphy.com/v1/gifs");
        public string GetRandom(string tag)
        {
            var request = new RestRequest("random");
            request.AddQueryParameter("tag", tag);
            request.AddQueryParameter("apiKey", "iqCe7luZhP7t1NEC0SXP4IASPmIl1XxV");
            var response = client.Execute<GiphyResponse>(request);
            if (response.IsSuccessful)
            {
                return response.Data.Data.Images.Original.Url;
            }

            return null;
        }
    }
}
