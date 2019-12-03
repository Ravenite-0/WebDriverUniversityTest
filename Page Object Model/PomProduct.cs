using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Page_Object_Model
{
    class PomProduct
    {
        protected IWebElement element;
        //Constructor ========================================================================================================
        public PomProduct(IWebElement element)
        {
            this.element = element;
        }

        //Item functionalities ===============================================================================================
        public String GetProductName() { return element.FindElement(By.ClassName("sub-heading")).Text; }

        public void ClickProduct() { element.Click(); }

    }
}
