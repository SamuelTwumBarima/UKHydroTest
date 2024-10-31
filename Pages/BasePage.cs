using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKHydroTest.Pages
{
    public class BasePage
    {
        // Property to hold the WebDriver instance
        protected IWebDriver _driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            // Assign the provided WebDriver instance to the class property
            this._driver = driver;
        }

        public void ClickOnLinkByText(string linkText)
        {
            IWebElement link = _driver.FindElement(By.LinkText(linkText));
            link.Click();
        }

        // Method to refresh the current page
        public void Refresh() => _driver.Navigate().Refresh();

        // Method to navigate to a specified URL
        public void OpenURl(string url) => _driver.Navigate().GoToUrl(url);

    }
}
