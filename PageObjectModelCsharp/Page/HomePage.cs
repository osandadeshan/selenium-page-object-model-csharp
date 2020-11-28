using OpenQA.Selenium;

namespace PageObjectModelCsharp.Page
{
    public class HomePage : BasePage
    {
        private readonly By _loggedInUsername = By.XPath("//a[@class='account']//span");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public string GetLoggedInUsername()
        {
            return GetElement(_loggedInUsername).Text;
        }
    }
}