using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModelCsharp.Page;

namespace PageObjectModelCsharp.Test
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private LoginPage _loginPage;
        
        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(Driver);
        }
        
        [Test(Description = "Verify that a user can login to the application with valid credentials")]
        public void TestValidUserLogin()
        {
            _loginPage.Login("osanda@mailinator.com", "1qaz2wsx@");
            Assert.AreEqual("Osanda Nimalarathna", new HomePage(Driver).GetLoggedInUsername());
            Assert.AreEqual("My account - My Store", Driver.Title);
        }
        
        [Test(Description = "Verify that a user cannot login to the application with invalid credentials")]
        public void TestInvalidUserLogin()
        {
            _loginPage.Login("osanda@mailinator.com", "1qaz2wsx");
            Assert.AreEqual("Login - My Store", Driver.Title);
        }
    }
}