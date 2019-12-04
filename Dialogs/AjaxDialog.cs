using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Dialogs
{
    class AjaxDialog
    {
        protected IWebElement element;
        //Constructor ========================================================================================================
        public AjaxDialog(IWebElement element)
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
            element.FindElement(By.TagName("button")).Click();
        }
    }
}
