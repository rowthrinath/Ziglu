using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit.Abstractions;
using ZigluTestAutomationFramework_ZeeTAF_.Commom.Context;

namespace ZigluTestAutomationCommon.CommonStepDefinitions
{
    [Binding]
    public class CommonStepDefs
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly CommonContext _commonContext;
        private readonly ITestOutputHelper output;

        public CommonStepDefs(ScenarioContext scenarioContext, ITestOutputHelper output)
        {
            _scenarioContext = scenarioContext;
            this.output = output;
        }

        //[Then(@"I get a (.*) response")]
        //public void ThenIGetAResponse(int statuscode)
        //{

        //    _commonContext.HttpStatusResponse.StatusCode.Should().Be(statuscode);
        //    if (statuscode == 200)
        //    {
        //        _commonContext.ResponseStatus = "Success";
        //    }
        //    if (statuscode == 401)
        //    {
        //        _commonContext.ResponseStatus = "Unauthorized";
        //    }
        //    if (statuscode == 400)
        //    {
        //        _commonContext.ResponseStatus = "Bad Request";
        //    }
        //    output.WriteLine($"The response is a {_commonContext.ResponseStatus}");
        //}

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Pending();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Pending();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            _scenarioContext.Pending();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            _scenarioContext.Pending();
        }
    }
}
