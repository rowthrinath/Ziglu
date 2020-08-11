using System;
using System.Collections.Generic;
using System.Text;
using ZigluTestAutomation.Dto;
using ZigluTestAutomationFramework_ZeeTAF_.Commom.Context;
using RestSharp;
using ZigluTestAutomationFramework_ZeeTAF_.DataObjects;
using Xunit.Abstractions;

namespace ZigluTestAutomation
{
   public class ApiMethods
    {
       private readonly CommonContext _commonContext;
        private readonly FootballApiContext _footballApiContext;
        RestClient _restClient;
        private readonly ITestOutputHelper output;
        public ApiMethods(CommonContext commoncontext, FootballApiContext footballapicontext, ITestOutputHelper output = null)
        {
            _commonContext = commoncontext;
            _footballApiContext = footballapicontext;
            this.output = output;
        }
        public void ExtractHighestScoringTeamsHome(InputParams inputParams)
        {
            try
            {
                _footballApiContext.Leauge1Response = GetHighestScoringTeamsHome(inputParams.Team1Endpoint);
                _footballApiContext.Leauge2Response = GetHighestScoringTeamsHome(inputParams.Team2Endpoint);
                _footballApiContext.Leauge3Response = GetHighestScoringTeamsHome(inputParams.Team3Endpoint);
            }
            catch (Exception ex)
            {
                output.WriteLine($"The following exception is thrown {ex.Message}");
            }
        }

        public void ExtractCoachDetails()
        {
            try
            {
                _footballApiContext.CoachResponse = GetCoachIdFromCoachName();
            }
            catch(Exception ex)
            {
                output.WriteLine($"The following exception is thrown {ex.Message}");
            }
        }

        public void GetTropiesByCoach(string endPoint)
        {
            try
            {
                _footballApiContext.TrophiesResponse = GetCoachTrophies(endPoint);
            }
            catch(Exception ex)
            {
                output.WriteLine($"The following exception is thrown {ex.Message}");
            }
        }

        public IRestResponse<LeaugeScoresDtoApi> GetHighestScoringTeamsHome(string endpoint)
        {
            try
            {
                _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            }
            catch(Exception ex)
            {
                output.WriteLine($"The following exception is thrown {ex.Message}");
            }
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
            IRestResponse<LeaugeScoresDtoApi> apiResponse = _restClient.Execute<LeaugeScoresDtoApi>(_restRequest);
            return apiResponse;
        }

        public IRestResponse GetStatusResponse(string endpoint)
        {
            try
            {
                _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            }
            catch (Exception ex)
            {
                output.WriteLine($"The following exception is thrown {ex.Message}");
            }
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
             
           _commonContext.HttpStatusResponse = _restClient.Execute(_restRequest);
            return _commonContext.HttpStatusResponse;
        }

        public IRestResponse<CoachDetailsDtoApi> GetCoachIdFromCoachName(string endpoint = "v2/coachs/search/Howe")
        {
            try
            {
                _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            }
            catch (Exception ex)
            {
                output.WriteLine($"The following exception is thrown {ex.Message}");
            }
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
            IRestResponse<CoachDetailsDtoApi> apiResponse = _restClient.Execute<CoachDetailsDtoApi>(_restRequest);
            return apiResponse;
        }

        public IRestResponse<TrophiesDtoApi> GetCoachTrophies(string endpoint)
        {
            try
            {
                _restClient = _commonContext.ApiAdapter.SetRestClient(_commonContext.service);
            }
            catch (Exception ex)
            {
                output.WriteLine($"The following exception is thrown {ex.Message}");
            }
            IRestRequest _restRequest = _commonContext.ApiAdapter.SetApiRequest(endpoint, Method.GET,
               _commonContext.ApiHostName, _commonContext.ApiKeyName, _commonContext.ApiHost, _commonContext.ApiKey);
            IRestResponse<TrophiesDtoApi> apiResponse = _restClient.Execute<TrophiesDtoApi>(_restRequest);
            return apiResponse;
        }

    }
}
