using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Dialogs;

namespace WebDriverUniversityTest.Page_Object_Model
{
    class PomProduct
    {
        protected IWebElement element;
        protected IWebDriver driver;
        //Constructor ========================================================================================================
        public PomProduct(IWebElement element, IWebDriver driver)
        {
            this.element = element;
            this.driver = driver;
        }

        //Item functionalities ===============================================================================================
        public String GetProductName() { return element.FindElement(By.CssSelector(".sub-heading")).Text; }

        public PomProductsPage ClickProduct()
        {
            element.Click();

            return new PomProductsPage(driver);
        }

    }
}
