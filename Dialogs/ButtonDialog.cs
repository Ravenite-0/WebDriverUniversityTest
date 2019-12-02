using OpenQA.Selenium;
using System;

namespace WebDriverUniversityTest
{
    class ButtonDialog
    {
        protected IWebElement element;
        //Constructor ========================================================================================================
        public ButtonDialog(IWebElement element)
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
