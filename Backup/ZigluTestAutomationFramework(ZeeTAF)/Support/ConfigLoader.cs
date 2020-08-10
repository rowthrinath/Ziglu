using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace ZigluTestAutomationFramework_ZeeTAF_.TestAutomationFramework.Config
{
    public static class ConfigLoader
    {
        private static IConfigurationRoot _currentConfig;

        public static  FootballApiDto LoadFootballApiConfig(string testEnv = null)
        {
            _currentConfig = GetIConfigurationRoot();
            testEnv = testEnv ?? _currentConfig["TestEnv"];
            var binFolder = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            var config = new FootballApiDto
            {
                ServiceUrl = _currentConfig["ServiceUrl"],
                EndPoint=_currentConfig["EndPoint"],
                ApiHostKeyNameValue = _currentConfig["rapidapi-host"],
                ApiKeyNameValue = _currentConfig["rapidapi-key"]
                
            };
            return config;
        }

        public static IConfigurationRoot GetConfigurationRoot()
        {
            var path = Directory.GetCurrentDirectory();
            if (!File.Exists(Path.Combine(path, "appsettings.json")))
            {
                throw new Exception($"Application settings file not found in {path}");
            }
            return new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true)
                .Build();
        }


        public static IConfigurationRoot GetIConfigurationRoot()
        {
            var path = Directory.GetCurrentDirectory();

            if (!File.Exists(Path.Combine(path, "appsettings.json")))
            {
                throw new Exception($"Could not find appsettings.json in {path}");
            }

            if (File.Exists(Path.Combine(path, "appsettings.json")))
            {
                return new ConfigurationBuilder()
                    .SetBasePath(path)
                    .AddJsonFile("appsettings.json", true)
                    .Build();
            }
            else
            {
                return new ConfigurationBuilder() 
                    .SetBasePath(path)
                    .AddJsonFile("", false)
                    .Build();
            }
            }

        }





    }
