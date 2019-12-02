using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Pages
{
    abstract class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickHome()
        {
            IList<IWebElement> elements = driver.FindElements(By.Id("nav-title"));
            if (elements.Count != 0) { elements[0].Click(); }
            //The condition is to close scenarios where the page does not have the option to return to the home page.
            else { throw new System.ArgumentException("This page does not have a HOME button!"); }
        }
    }
}
