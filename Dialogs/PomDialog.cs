using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Dialogs
{
    class PomDialog
    {
        protected IWebElement element;
        //Constructor ========================================================================================================
        public PomDialog(IWebElement element)
        {
            this.element = element;
        }

        //Dialog Functionalities =============================================================================================
        public String GetTitle()
        {
            return element.FindElement(By.ClassName("modal-title")).Text;
        }

        public void CloseDialog()
        {
            element.FindElement(By.XPath("//button[contains(text(),'Close')]")).Click();
        }

        public void ProceedDialog()
        {
            //In this scenario it acts exactly the same to close button.
            element.FindElement(By.XPath("//button[contains(text(),'Proceed')]")).Click();
        }
    }
}
