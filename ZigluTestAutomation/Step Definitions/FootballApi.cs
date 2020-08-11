using System.Linq;
using ZigluTestAutomationFramework_ZeeTAF_.Commom;
using TechTalk.SpecFlow;
using FluentAssertions;
using Xunit.Abstractions;
using TechTalk.SpecFlow.Assist;
using ZigluTestAutomation.Dto;
using ZigluTestAutomationFramework_ZeeTAF_.Commom.Context;

namespace ZigluTestAutomation.Step_Definitions
{
    [Binding]
    public  sealed class FootballApi
    {

        private readonly CommonContext _commonContext;
        private readonly ScenarioContext _scenarioContext;
        private readonly FootballApiContext _footballApiContext;
        private readonly ApiMethods _apiMethods;
        private readonly ITestOutputHelper output;

        public FootballApi(CommonContext commoncontext, FootballApiContext footballapicontext, ScenarioContext scenariocontext, ITestOutputHelper output)
        {
            _commonContext = commoncontext;
            _scenarioContext = scenariocontext;
            _footballApiContext = footballapicontext;
            _commonContext.service = _footballApiContext.FootballApiService;
            _commonContext.ApiHostName = _footballApiContext.FootballApiHostKeyName;
            _commonContext.ApiKeyName = _footballApiContext.FootballApiKeyName;
            _commonContext.ApiHost = _footballApiContext.FootballApiHost;
            _commonContext.ApiKey = _footballApiContext.FootballApiKey;
            _apiMethods = new ApiMethods(commoncontext, footballapicontext);
            this.output = output;
        }

        [Given(@"I have access  to football api service")]
        public void GivenIHaveAccessToFootballApiService()
        {
            _commonContext.service = _footballApiContext.FootballApiService;
            _commonContext.ServiceMethods = new ServiceMethods(_commonContext);
           
        }

        [When(@"I submit a get on (.*) endpoint")]
        public void WhenISubmitAGetOnEndpoint(string endpoint)
        {
            _apiMethods.GetStatusResponse(endpoint);
        }

        [Then(@"I get a (.*) response")]
        public void ThenIGetAResponse(int statuscode)
        {

            _commonContext.HttpStatusResponse.StatusCode.Should().Be(statuscode);
            if (statuscode == 200)
            {
                _commonContext.ResponseStatus = "Success";
            }
            if (statuscode == 401)
            {
                _commonContext.ResponseStatus = "Unauthorized";
            }
            if (statuscode == 400)
            {
                _commonContext.ResponseStatus = "Bad Request";
            }
            output.WriteLine($"The response is a {_commonContext.ResponseStatus}");
        }

        [When(@"I get the home goals scored by the teams")]
        public void WhenIHaveTheGoalsScoredBy(Table table)
         {
            _footballApiContext.InputParams = table.CreateInstance<InputParams> ();
            _apiMethods.ExtractHighestScoringTeamsHome(_footballApiContext.InputParams);
            _footballApiContext.leauge1Score = _footballApiContext.leauge1Response.Data.Api.statistics.Goals.GoalsFor.FirstOrDefault().home;
            _footballApiContext.leauge2Score = _footballApiContext.leauge2Response.Data.Api.statistics.Goals.GoalsFor.FirstOrDefault().home;
            _footballApiContext.leauge3Score = _footballApiContext.leauge3Response.Data.Api.statistics.Goals.GoalsFor.FirstOrDefault().home;
        }


        [Then(@"I should be able to find the most scored team in home games")]
        public void ThenIShouldBeBeAbleFindTheMostScoredTeam()
        {
            
            if (_footballApiContext.leauge1Score > _footballApiContext.leauge2Score && _footballApiContext.leauge1Score > _footballApiContext.leauge3Score)
            {
                _footballApiContext.HighestScoringTeamInHome = _footballApiContext.InputParams.Team1;
            }
            else if (_footballApiContext.leauge2Score > _footballApiContext.leauge1Score && _footballApiContext.leauge2Score > _footballApiContext.leauge3Score)
            {
                _footballApiContext.HighestScoringTeamInHome = _footballApiContext.InputParams.Team2;
            }
            else
            {
                _footballApiContext.HighestScoringTeamInHome = _footballApiContext.InputParams.Team3;
            }
            output.WriteLine($"The team with most goals scored  from home games is { _footballApiContext.HighestScoringTeamInHome}");
        }

        [When(@"I get the wins by the teams")]
        public void WhenIGetTheWinsByTheTeams(Table table)
        {
            _footballApiContext.InputParams = table.CreateInstance<InputParams>();
            _apiMethods.ExtractHighestScoringTeamsHome(_footballApiContext.InputParams);
            _footballApiContext.leauge1Wins = _footballApiContext.leauge1Response.Data.Api.statistics.Matchs.Wins.FirstOrDefault().total;
            _footballApiContext.leauge2Wins = _footballApiContext.leauge2Response.Data.Api.statistics.Matchs.Wins.FirstOrDefault().total;
            _footballApiContext.leauge3Wins = _footballApiContext.leauge3Response.Data.Api.statistics.Matchs.Wins.FirstOrDefault().total;

        }

        [Then(@"I should be able to find the team in form")]
        public void ThenIShouldBeAbleToFindTheTeamInForm()
        {
            if (_footballApiContext.leauge1Wins > _footballApiContext.leauge2Wins && _footballApiContext.leauge1Wins > _footballApiContext.leauge3Wins)
            {
                _footballApiContext.HighestWinningTeam = _footballApiContext.InputParams.Team1;
            }
            else if (_footballApiContext.leauge2Wins > _footballApiContext.leauge1Wins && _footballApiContext.leauge2Wins > _footballApiContext.leauge3Wins)
            {
                _footballApiContext.HighestWinningTeam = _footballApiContext.InputParams.Team2;
            }
            else
            {
                _footballApiContext.HighestWinningTeam = _footballApiContext.InputParams.Team3;
            }
            output.WriteLine($"The team with best of form is { _footballApiContext.HighestWinningTeam}");
        }

        [When(@"I have the results and tropies of (.*)")]
        public void WhenIHaveTheResultsAndTropiesOfEddieHowe(string coachName)
        {
            _apiMethods.ExtractCoachDetails();
            var coachId = _footballApiContext.CoachResponse.Data.Api.coachs.FirstOrDefault().id;
          _apiMethods.GetTropiesByCoach($"v2/trophies/coach/{coachId}");
            _footballApiContext.trophiesForCoach = _footballApiContext.TrophiesResponse.Data.Api.Trophies;
        }

        [Then(@"I should be able to see the results and tropies of Eddie Howe output")]
        public void ThenIShouldBeAbleToSeeTheResultsAndTropiesOfEddieHoweOutput()
        {
            foreach (var item in _footballApiContext.trophiesForCoach)
            {
                output.WriteLine($" Leauge in which trophy was won : { item.leauge}");
                output.WriteLine($" Country in which trophy was won : { item.country}");
                output.WriteLine($" Season in which trophy was won : { item.season}");
                output.WriteLine($" Place in which trophy was won : { item.place}");
            }
        }


    }
}
