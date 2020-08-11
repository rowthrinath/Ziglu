using Dynamitey.DynamicObjects;
using RestSharp;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using ZigluTestAutomation;
using ZigluTestAutomation.Dto;
using ZigluTestAutomationFramework_ZeeTAF_.DataObjects;
using ZigluTestAutomationFramework_ZeeTAF_.TestAutomationFramework.Config;

namespace ZigluTestAutomationFramework_ZeeTAF_.Commom.Context
{
    public class FootballApiContext : IDisposable
    {
        FootballApiDto _footballDto = ConfigLoader.LoadFootballApiConfig();
        public FootballApiContext(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;         
        }

        public int HighestHomeScore { get; set; }
        public string HighestScoringTeamInHome { get; set; }
        public string HighestWinningTeam { get; set; }
        public IRestResponse<LeaugeScoresDtoApi> Leauge1Response { get; set; }
        public IRestResponse<LeaugeScoresDtoApi> Leauge2Response { get; set; }
        public IRestResponse<LeaugeScoresDtoApi> Leauge3Response { get; set; }
        public IRestResponse<TrophiesDtoApi> TrophiesResponse { get; set; }
        public IRestResponse<CoachDetailsDtoApi> CoachResponse { get; set; }
        public string ResponseStatus = "Success";
        public int Leauge1Score { get; set; }
        public int Leauge2Score { get; set; }
        public int Leauge3Score { get; set; }
        public int Leauge1Wins { get; set; }
        public int Leauge2Wins { get; set; }
        public int Leauge3Wins { get; set; }
        public InputParams InputParams { get; set; }
        public List<Trophies> TrophiesForCoach { get; set; }
        public ScenarioContext ScenarioContext { get; }
        public Exception FootballApiException { get; set; }       
        public string FootballApiService => _footballDto.ServiceUrl;
        public string FootballApiHostKeyName => "x-rapidapi-host";
        public string FootballApiKeyName => "x-rapidapi-key";

        public string FootballApiHost => _footballDto.ApiHostKeyNameValue;
        public string FootballApiKey => _footballDto.ApiKeyNameValue;

        public void Dispose()
        {
            
        }
    }
}
