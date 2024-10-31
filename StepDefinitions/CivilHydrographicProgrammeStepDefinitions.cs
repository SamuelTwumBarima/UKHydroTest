using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UKHydroTest.Pages;
using UKHydroTest.Support;

namespace UKHydroTest.StepDefinitions
{
    [Binding]
    public class CivilHydrographicProgrammeStepDefinitions
    {
        private UKHydroPage ukHydroPage;
        private CivilHydroPage civilHydroPage;
        private readonly IWebDriver _driver;

        public CivilHydrographicProgrammeStepDefinitions(IWebDriver driver) 
        {
            _driver = driver;
            ukHydroPage = new UKHydroPage(_driver);
            civilHydroPage = new CivilHydroPage(_driver);
        }

        [Given(@"I open the UK hydrographic office page")]
        public void GivenIOpenTheUKHydrographicOfficePage()
        {
            ukHydroPage.OpenUrl(ConfigurationReader.UKHydrographicURL);
        }

        [Then(@"I validate that the details are displayed")]
        public void ThenIValidateThatTheDetailsAreDisplayed(Table table)
        {
            // dictionary to store expected values from the table
            Dictionary<string, string> expectedData = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                expectedData[row["Input"]] = row["Value"];
            }

            // Retrieve and validate each expected value against actual value from the page
            string fromExpected = expectedData["From"];
            string publishedExpected = expectedData["Published"];
            string lastUpdatedExpected = expectedData["Last updated"] + " — See all updates";

            // Locate actual values from the web page elements using Selenium
            string fromActual = civilHydroPage.fromActual;
            string publishedActual = civilHydroPage.publishedActual;
            string lastUpdatedActual = civilHydroPage.lastUpdatedActual;

            // Assert that the actual values match the expected values
            Assert.AreEqual(fromExpected, fromActual, "The 'From' value does not match.");
            Assert.AreEqual(publishedExpected, publishedActual, "The 'Published' date does not match.");
            Assert.AreEqual(lastUpdatedExpected, lastUpdatedActual, "The 'Last updated' date does not match.");
        }
    }
}
