using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TurnUp_portal.Pages;

internal class Program
{
    private static void Main(string[] args)
    {
        //Open Chrome browser
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1800);
        //driver.SwitchTo().Alert().Accept();
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateMaterialRecord(driver);
        tmPageObj.CreateTimeRecord(driver);

    }
}

