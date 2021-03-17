using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.HttpService
{
    public class HttpService: IHttpService
    {
        public HttpService()
        {
        }

        public string Get(Dictionary<string, string> param, string url)
        {
            var restClient = new RestClient(url);
            var restRequest = new RestRequest(Method.GET);
            foreach (var item in param)
            {
                restRequest.AddParameter(item.Key, item.Value);
            }
            var response = restClient.Execute(restRequest);
            return response.Content;
        }
    }
}
