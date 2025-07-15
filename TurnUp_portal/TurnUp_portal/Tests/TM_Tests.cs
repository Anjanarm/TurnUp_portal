using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp_portal.Pages;
using TurnUp_portal.Utilities;

namespace TurnUp_portal.Tests
{
    [TestFixture]
    public class TM_tests: CommonDrivers
    {
        [SetUp]
        public void SetupSteps()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1800);
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);
        }
        [Test]
        public void CreateTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);
        }
        [Test]
        public void CreateMaterial_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateMaterialRecord(driver);
        }
        [TearDown]
        public void CloseTest_Run()
        {
            driver.Quit();
        }
    }
}
