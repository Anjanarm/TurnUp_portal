# NUnit Selenium Test Framework 

This project contains NUnit Test Framework in C# using Selenium WebDriver for UI based Application

#Project Structure

/Pages - Page Object Model Classes
/Tests - NUnit Tests
/Utilities - Contains drivers and general configuration file

# Prerequisites

Install Visual Studio with '.NET Desktop Development' and 'ASP.NET and web development' workloads.
https://www.visualstudio.com/vs/community/

Install the folllowing packages using Nuget Packet Manager:
Microsoft.Net.Test.SDK
NUnit
NUnit3TetsAdapter
Selenium.Support
Selenium.WebDriver
Selenium.WebDriver.ChromeDriver
SeleniumExtras.WaitHelpers

# How to run tests:
In Visual Studio under Test Choose Test Explorer
Run All Tests in a single view or click on a test to be executed and select the second run option

# Example Test Flow
CreateMaterial_Test
Login to the portal using Username and password
Navigate to Administration Tab and choose Time and Material from Dropdown
Click on the create button and enter the data in fields
Go to the last page and validate that the newly enetred data is present