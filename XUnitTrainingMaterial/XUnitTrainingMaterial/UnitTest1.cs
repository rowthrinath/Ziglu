using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using Xunit;


namespace XUnitTrainingMaterial
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //IWebDriver driver;
            //FirefoxOptions firefoxOptions = new FirefoxOptions();
            //driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //driver.Navigate().GoToUrl("https://gmail.com");
            //driver.Quit();

            GetStoreItems("https://virtserver.swaggerhub.com/testperfectlimited/testhealt/1.0.0/store/inventory");
        }


        public string GetStoreItems(string url)
        {
            using (var httpClient = new HttpClient())
            {
                //httpClient.DefaultRequestHeaders.Add(RequestConstants.UserAgent, RequestConstants.UserAgentValue);
                var response = httpClient.GetStringAsync(new Uri(url)).Result;

                return response;
            }
        }



    }
}
