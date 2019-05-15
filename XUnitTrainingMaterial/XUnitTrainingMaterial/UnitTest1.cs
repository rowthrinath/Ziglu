using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace XUnitTrainingMaterial
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver;
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Navigate().GoToUrl("https://gmail.com");
            driver.Quit();
        }
    }
}
