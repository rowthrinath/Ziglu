using System;
using System.Collections.Generic;
using System.Text;
using ZigluTestAutomation.Dto;
using ZigluTestAutomationFramework_ZeeTAF_.Commom.Context;
using RestSharp;
using ZigluTestAutomationFramework_ZeeTAF_.DataObjects;

namespace ZigluTestAutomation
{
   public class ApiMethods
    {
       private readonly CommonContext _commonContext;
        private readonly FootballApiContext _footballApiContext;
        RestClient _restClient;


        public ApiMethods(CommonContext commoncontext, FootballApiContext footballapicontext)
        {
            _commonContext = commoncontext;
            _footballApiContext = footballapicontext;
        }

        public void ExtractHighestScoringTeamsHome(InputParams inputParams)
        {
            _footballApiContext.leauge1Response = GetHighestScoringTeamsHome(inputParams.Team1Endpoint);
            _footballApiContext.leauge2Response = GetHighestScoringTeamsHome(inputParams.Team2Endpoint);
            _footballApiContext.leauge3Response = GetHighestScoringTeamsHome(inputParams.Team3Endpoint);

        }

        public void ExtractCoachDetails()
        {
            _footballApiContext.CoachResponse = GetCoachIdFromCoachName();

        }

        public void GetTropiesByCoach(string endPoint)
        {
            _footballApiContext.TrophiesResponse = GetCoachTrophies(endPoint);

        }


        public IRestResponse<LeaugeScoresDtoApi> GetHighestScoringTeamsHome(string endpoint)
        {            
            _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
            IRestResponse<LeaugeScoresDtoApi> apiResponse = _restClient.Execute<LeaugeScoresDtoApi>(_restRequest);
            return apiResponse;
        }

        public IRestResponse GetStatusResponse(string endpoint)
        {
            _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
             
           _commonContext.HttpStatusResponse = _restClient.Execute(_restRequest);
            return _commonContext.HttpStatusResponse;
        }


        public IRestResponse<CoachDetailsDtoApi> GetCoachIdFromCoachName(string endpoint = "v2/coachs/search/Howe")
        {
            _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
            IRestResponse<CoachDetailsDtoApi> apiResponse = _restClient.Execute<CoachDetailsDtoApi>(_restRequest);
            return apiResponse;
        }

        public IRestResponse<TrophiesDtoApi> GetCoachTrophies(string endpoint)
        {
            _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
            IRestResponse<TrophiesDtoApi> apiResponse = _restClient.Execute<TrophiesDtoApi>(_restRequest);
            return apiResponse;
        }

    }
}
