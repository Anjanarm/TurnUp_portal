using OpenQA.Selenium;
using TurnUp_portal.Utilities;

namespace TurnUp_portal.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            //Launch TurnUp Portal
            driver.Navigate().GoToUrl(Config.BaseUrl);
            driver.Manage().Window.Maximize();

            //Identify username textbox and enter username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys(Config.Username);

            //Identify password textbox and enter password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys(Config.Password);

            //Identify Login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

            loginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
