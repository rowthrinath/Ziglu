using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;
using XUnitTrainingMaterial.PageObjects;

namespace XUnitTrainingMaterial.StepDefinitions
{
    [Binding]
    public class GmailTest
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly BrowserContext _browserContext;
        private readonly GmailTestSteps _gmailTest;
        public GmailTest(BrowserContext browserContext)
        {
            _browserContext = browserContext;
            _gmailTest = new GmailTestSteps(browserContext);
        }

        [Given(@"I have gmail login page loaded")]
        public void GivenIHaveGmailLoginPageLoaded()
        {
            _gmailTest.NavigateToGmail();
        }

        [Given(@"I enter an invalid user name and password")]
        public void GivenIEnterAnInvalidUserNameAndPassword()
        {
            _browserContext.WebDriver.WaitForPageToLoad();
            _gmailTest.LoginToGmail();
            _browserContext.CaptureScreenshot();
        }

    }
}
