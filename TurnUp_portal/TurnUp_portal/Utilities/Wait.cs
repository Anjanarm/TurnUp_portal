using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace TurnUp_portal.Utilities;

public class Wait
{
    // Generic function to wait for an element to be clickable
    public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
    {
        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

        if (locatorType == "XPath")
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }
        if (locatorType == "Id")
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }

    }
    // Generic function to wait for an element to be visible
    public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
    {
        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

        if (locatorType == "XPath")
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }
        if (locatorType == "Id")
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }
    }
}

