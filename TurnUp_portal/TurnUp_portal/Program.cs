using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Open Chrome browser
        IWebDriver driver = new ChromeDriver();

        //Launch TurnUp Portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io");
        driver.Manage().Window.Maximize();

        //Identify username textbox and enter username
        IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
        usernameTextBox.SendKeys("hari");
        Thread.Sleep(5000);

        //Identify password textbox and enter password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        //Identify Login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

        loginButton.Click();
        Thread.Sleep(5000);

        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("User has successsfully logged in, Test passed");
        }
        else
        {
            Console.WriteLine("User has not logged in, Test failed");

        }
        //Create Time and Materail Record
        //Navigate to Time Material page
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        administrationTab.Click();

        IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeAndMaterialOption.Click();
        
        //Click Create button
       IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
       createButton.Click();


        //Choose Time from dropdown
        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typeCodeDropdown.Click();

        IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        materialOption.Click();


        //Type Code into textbox
        IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
        codeTextBox.SendKeys("TA Programme");

        //Type description into textbox
        IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        descriptionTextbox.SendKeys("This is a description");

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
        if (newCode.Text == "TA Programme")
        {
            Console.WriteLine("New Material Record Created Successfully");
        }
        else {
            Console.WriteLine("New record has not been created");

        }

        }
}