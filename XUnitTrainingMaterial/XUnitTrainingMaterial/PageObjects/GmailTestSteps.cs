using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTrainingMaterial.PageObjects
{
  public  class GmailTestSteps
    {
        private readonly  BrowserContext _browserContext;
        private IWebDriver _driver;
        public GmailTestSteps(BrowserContext browserContext)
        {
            _browserContext = browserContext;
        }

        public void NavigateToGmail()
        {
            _browserContext.WebDriver.Navigate().GoToUrl("https://gmail.com");
        }

        public void  LoginToGmail()
        {
            _browserContext.WebDriver.FindElement(By.Id("identifierId")).SendKeys("HEE");
        }
    }
}
