using NUnit.Framework;
using OpenQA.Selenium;

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
            
            Assert.That(newCode.Text == "TA Programme", "New time record has not been created");
        }
        /*Create a record with specific code and check the
        newly created record has been deleted
        */
        public void DeleteRecord(IWebDriver driver)
        {

            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));

            timeOption.Click();

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Code to delete");

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

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
           

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1500);

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

            IWebElement currentLast = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(currentLast.Text != "Code to delete", "Delete operation is not successful");
        
        }
        //Edit the Code element of last element field
        public void EditRecord(IWebDriver driver)
        {
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.Clear();
            codeTextBox.SendKeys("Edited Code");

            IWebElement saveOption = driver.FindElement(By.Id("SaveButton"));
            saveOption.Click();
            Thread.Sleep(3000);

            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();

            IWebElement currentLast = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(currentLast.Text == "Edited Code", "Edit operation is not successful");



        }
    }
}