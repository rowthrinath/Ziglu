using RestSharp;


namespace ZigluTestAutomationFramework_ZeeTAF_.Adapters
{
    public class ApiAdapter
    {
        private RestClient apiClient;
        RestRequest apiRequest;
        public ApiAdapter(string apiService)
        {
            apiClient = new RestClient(apiService);
        }

        public RestClient SetRestClient(string apiService)
        {
            return apiClient = new RestClient(apiService);
        }

        public RestRequest SetApiRequest(string endPoint, Method apiMethod,
        string headerHostName = null, string apiKeyName = null, string headerHost = null, string apiKey = null)
        {
            apiRequest = new RestRequest(endPoint, apiMethod);
            apiRequest.AddHeader(headerHostName, headerHost);
            apiRequest.AddHeader(apiKeyName, apiKey);          
            return apiRequest;
        }




    }
}
