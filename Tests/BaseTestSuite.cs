using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverUniversityTest
{
    abstract class BaseTestSuite
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAll()
        {
            //Uncomment to run the tests in headless mode.
            /*
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximised");
            option.AddArgument("headless");
            */

            //Comment accordingly based on whether option is setup.
            //driver = new ChromeDriver(option);
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [SetUp]
        public void BeforeEach()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            //Comment line 34 if running ChromeOptions.
            driver.Manage().Window.Maximize();
            driver.Url = "http://webdriveruniversity.com/";
        }

        [TearDown]
        public void AfterEach()
        { 
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            driver.Quit();
        }
    }
}
