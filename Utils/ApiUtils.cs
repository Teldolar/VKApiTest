using RestSharp;

namespace VkApi.Utils
{
    public static class ApiUtils
    {
        public static string Post(string url)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(url,Method.POST);
            return restClient.Post(restRequest).Content;
        }

        public static string Get(string url)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(url);
            var asd = restClient.Get(restRequest);
            return asd.Content;
        }
    }
}