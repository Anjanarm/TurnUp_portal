using NUnit.Framework;
using OpenQA.Selenium;
using TurnUp_portal.Utilities;

namespace TurnUp_portal.Pages
{
    public class HomePage
    {
        
        // Navigate to Time and Material Page
        public void NavigateToTMPage(IWebDriver driver)
        {
            try
            {
                IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
                administrationTab.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Administration tab not found");
                Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);
            }
            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();
        }
    }
}
