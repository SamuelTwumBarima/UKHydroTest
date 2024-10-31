using OpenQA.Selenium;

namespace UKHydroTest.Pages
{
   
    public class UKHydroPage :BasePage
    {
        // Public property to hold the WebDriver instance
        public IWebDriver _driver;

        // Constructor to initialize UKHydroPage with a WebDriver instance, passing it to the base class
        public UKHydroPage(IWebDriver driver) : base(driver)
        {
        }

        #region Locators
        // Define locators here for specific elements on the UK Hydro page
        #endregion

        // Method to open a specific URL in the browser
        public void OpenUrl(string url)
        {
            // Use the inherited OpenURL method from BasePage
            OpenURl(url);
        }

        // Method to select a hyperlink by its visible name
        public void SelectHyperLink(string linkName)
        {
            // Use the inherited ClickOnLinkByText method from BasePage to click the link
            ClickOnLinkByText(linkName);
        }
    }
}