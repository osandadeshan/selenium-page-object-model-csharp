using OpenQA.Selenium;

namespace PageObjectModelCsharp.Page
{
    public class LoginPage : BasePage
    {
        private readonly By _emailTextBox = By.Id("email");
        private readonly By _passwordTextBox = By.Id("passwd");
        private readonly By _signInButton = By.Id("SubmitLogin");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        public void SetEmail(string email)
        {
            SendKeys(_emailTextBox, email);
        }
        
        public void SetPassword(string password)
        {
            SendKeys(_passwordTextBox, password);
        }

        public void ClickSignInButton()
        {
            Click(_signInButton);
        }

        public void Login(string email, string password)
        {
            SetEmail(email);
            SetPassword(password);
            ClickSignInButton();
        }
    }
}