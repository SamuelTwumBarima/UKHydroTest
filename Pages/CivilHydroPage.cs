using OpenQA.Selenium;

namespace UKHydroTest.Pages
{
    public class CivilHydroPage : BasePage
    {
        public CivilHydroPage(IWebDriver driver) : base(driver) { }

        #region Locators
        public string fromActual => _driver.FindElement(By.LinkText("UK Hydrographic Office")).Text;
        public string publishedActual => _driver.FindElement(By.CssSelector("#content > div:nth-child(3) > div > div.govuk-grid-column-two-thirds.metadata-column > div > dl > dd:nth-child(4)")).Text;
        public string lastUpdatedActual => _driver.FindElement(By.CssSelector("#content > div:nth-child(3) > div > div.govuk-grid-column-two-thirds.metadata-column > div > dl > dd:nth-child(6)")).Text;


        #endregion



    }
}