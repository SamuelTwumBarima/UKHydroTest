using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKHydroTest.Support
{
    public static class ConfigurationReader
    {
        // Holds the configuration object
        private static IConfiguration Configuration { get; set; }

        // Static constructor to initialize the configuration
        static ConfigurationReader()
        {
            // Build the configuration from the "AppSettings.json" file
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("AppSettings.json")  // Load settings from the specified JSON file
                .Build();  // Build the configuration


        }

        // Property to get the current environment setting
        public static string CurrentEnvironment => Configuration["CurrentEnvironment"];
        // Property to get the configuration section for the current environment
        public static IConfigurationSection EnvironmentDetails =>
            Configuration.GetSection("Environments").GetSection(CurrentEnvironment);

        // Property to get the SauceDemo URL for the current environment
        public static string UKHydrographicURL => EnvironmentDetails["UKHydrographicURL"];
    }
}
