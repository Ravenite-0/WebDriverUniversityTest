using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverUniversityTest.ListItem
{
    class ToDoListItem
    {
        protected IWebElement element;
        protected IWebDriver driver;

        //Constructor ========================================================================================================
        public ToDoListItem (IWebElement element, IWebDriver driver)
        {
            this.element = element;
            this.driver = driver;
        }

        //Item Functionalities ===============================================================================================
        public String GetTaskName()
        {
            return this.element.Text;
        }

        public ToDoListItem SetItemStatus()
        {
            this.element.Click();
            return this;
        }

        public void DeleteItem()
        {
            new Actions(driver).MoveToElement(element).Build().Perform();
            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.TagName("i")));
            driver.FindElement(By.XPath("//*[contains(text(),'" + this.GetTaskName() +"')]")).FindElement(By.CssSelector(".fa-trash")).Click();
            
            return;
        }
    }
}
