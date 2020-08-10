using FluentAssertions;
using TechTalk.SpecFlow;
using ZigluTestAutomationFramework_ZeeTAF_.Commom.Context;

namespace ZigluTestAutomationCommon.CommonStepDefinitions
{
    [Binding]
    public sealed class ApiActions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly CommonContext _commonContext;

        public ApiActions(CommonContext commoncontext)
        {
            _commonContext = commoncontext;
        }

    }
}
