using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Pages
{
    class ToDoListPage : BasePage
    {
        //Constructor ========================================================================================================
        public ToDoListPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Functions for entire list interactions =============================================================================
        public void ClickAddItem()
        {
            driver.FindElement(By.Id("plus-icon")).Click();
        }

        public void SetNewTask(String taskName)
        {
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("[style='display: none;']"));

            if (elements.Count > 0) { ClickAddItem(); }
            driver.FindElement(By.TagName("input")).SendKeys(taskName);
            driver.FindElement(By.TagName("body")).SendKeys(Keys.Enter);
        }
    }
}
