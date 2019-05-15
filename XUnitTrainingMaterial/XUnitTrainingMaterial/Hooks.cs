using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace XUnitTrainingMaterial
{
    [Binding]
    public  class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly BrowserContext _browserContext;
        private IWebDriver _driver;
        public Hooks(BrowserContext browserContext)
        {
            _browserContext = browserContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _browserContext.WebDriver.Quit();
        }

        
    }
}
