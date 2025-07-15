using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp_portal.Utilities;

namespace TurnUp_portal.Pages
{
    public class TMPage
    {
        public void CreateMaterialRecord(IWebDriver driver)
        {
            
            //Click Create button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();


            //Choose Time from dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

     

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));
            materialOption.Click();
            

            //Type Code into textbox
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("TA Programme");

            //Type description into textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("This is material description");

            //Type price into textbox
            IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceOverlap.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("4123");

            //Wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);

            //Click on save button
            IWebElement saveOption = driver.FindElement(By.Id("SaveButton"));
            saveOption.Click();
            Thread.Sleep(3000);

            //Check if record has been created
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //if (newCode.Text == "TA Programme")
            //{
            //    Assert.Pass("New Material Record Created Successfully");
            //}
            //else
            //{
            //    Assert.Fail("New record has not been created");
            //}
            Assert.That(newCode.Text == "TA Programme", "New record has not been created");
        }
        public void CreateTimeRecord(IWebDriver driver)
           {

               //Click Create button
               IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
               createButton.Click();


               //Choose Time from dropdown
               IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
               typeCodeDropdown.Click();

               IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
           
               timeOption.Click();


               //Type Code into textbox
               IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
               codeTextBox.SendKeys("TA Programme");

               //Type description into textbox
               IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
               descriptionTextbox.SendKeys("This is time description");

               //Type price into textbox
               IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
               priceOverlap.Click();

               IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
               priceTextbox.SendKeys("4123");

               //Click on save button
               IWebElement saveOption = driver.FindElement(By.Id("SaveButton"));
               saveOption.Click();
               Thread.Sleep(3000);

               //Check if record has been created
               IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
               lastPageButton.Click();

               IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
               //if (newCode.Text == "TA Programme")
               //{
               //    Assert.Pass("New Material Record Created Successfully");
               //}
               //else
               //{
               //    Assert.Fail("New record has not been created");
               //}
            Assert.That(newCode.Text == "TA Programme", "New time record has not been created");
           }
        /*
           public void DeleteRecord()
           {

           }*/
    }
}
