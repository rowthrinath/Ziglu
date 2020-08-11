using RestSharp;
using System;
using TechTalk.SpecFlow;
using ZigluTestAutomation;
using ZigluTestAutomationFramework_ZeeTAF_.Adapters;

namespace ZigluTestAutomationFramework_ZeeTAF_.Commom.Context
{
    public class CommonContext : IDisposable
    {
        public CommonContext(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        public IRestResponse HttpStatusResponse { get; set; }
        public IRestResponse<LeaugeScoresDtoApi> HttpResponse { get; set; }
        public ServiceMethods ServiceMethods { get; set; }
        public ScenarioContext ScenarioContext { get; }
        public Exception Exception { get; set; }
        public ApiAdapter ApiAdapter { get; set; }
        public string ResponseStatus = "Success";
        public string service { get; set; }
        public string ApiHostName { get; set; }
        public string ApiKeyName { get; set; }
        public string ApiHost { get; set; }
        public string ApiKey { get; set; }

        public void Dispose()
        {
            
        }
    }
}
