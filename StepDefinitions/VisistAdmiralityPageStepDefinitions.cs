using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using UKHydroTest.Pages;

namespace UKHydroTest.StepDefinitions
{
    [Binding]
    public class VisistAdmiralityPageStepDefinitions
    {
        private UKHydroPage ukHydroPage;
        private readonly IWebDriver _driver;

        public VisistAdmiralityPageStepDefinitions(IWebDriver driver) 
        {
            _driver = driver;
            ukHydroPage = new UKHydroPage(_driver);
        }

        [Given(@"I go to url ""([^""]*)""")]
        public void GivenIGoToUrl(string url)
        {
            ukHydroPage.OpenUrl(url);
        }

        [Given(@"I select ""([^""]*)""")]
        public void GivenISelect(string linkName)
        {
            ukHydroPage.SelectHyperLink(linkName);
        }

        [Then(@"I should be on the admiralty homepage")]
        public void ThenIShouldBeOnTheAdmiraltyHomepage()
        {
            string expectedTitle = "ADMIRALTY";
            expectedTitle.Should().Be(_driver.Title,"The user should be redirected to the ADMIRALTY page");
        }

        [Given(@"I select ""([^""]*)"" link")]
        public void GivenISelectLink(string linkName)
        {
            ukHydroPage.SelectHyperLink(linkName);
        }

        [Then(@"I should be on the ""([^""]*)"" homepage")]
        public void ThenIShouldBeOnTheHomepage(string pageTitle)
        {
            string expectedText = pageTitle;
            expectedText.Should().Be(_driver.Title, "");
        }

    }
}
