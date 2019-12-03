using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Page_Object_Model;

namespace WebDriverUniversityTest.Pages
{
    class PageObjectModelPage : BasePage
    {
        //Constructor ========================================================================================================
        public PageObjectModelPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Menu interactions ==================================================================================================
        public PageObjectModelPage ClickPomHome()
        {
            driver.FindElement(By.CssSelector(".navbar [href='index.html']")).Click();
            return this;
        }

        public PomProductsPage ClickPomProducts()
        {
            driver.FindElement(By.CssSelector(".navbar [href='products.html']")).Click();
            return new PomProductsPage(driver);
        }

        public ContactUsPage ClickPomContact()
        {
            driver.FindElement(By.CssSelector(".navbar [href='contactus.html']")).Click();
            return new ContactUsPage(driver);
        }
    }
}
