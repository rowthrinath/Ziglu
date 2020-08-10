using ZigluTestAutomationFramework_ZeeTAF_.Commom.Context;
using ZigluTestAutomationFramework_ZeeTAF_.Adapters;
using RestSharp;
using ZigluTestAutomation;

namespace ZigluTestAutomationFramework_ZeeTAF_.Commom
{
    public class ServiceMethods
    {
        private readonly CommonContext _commonContext;
        public ServiceMethods(CommonContext commonContext)
        {
            _commonContext = commonContext;
            _commonContext.ApiAdapter = new ApiAdapter(_commonContext.service);
            
        }

        public IRestResponse GetMethod(string endpoint)
        {
            RestClient restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
            IRestResponse apiResponse = restClient.Execute(_restRequest);
            return apiResponse;
        }
    }
}
