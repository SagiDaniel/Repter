using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebTest
{
    public class Tests
    {
        String test_url = "http://localhost:5173/Foglalas";

        IWebDriver driver;
        [SetUp]
        public void start_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        { /*
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("LambdaTest");

            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));

            searchButton.Click();

            System.Threading.Thread.Sleep(6000);

            Console.WriteLine("Test Passed");

            !!   Példa

            */

        }
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}