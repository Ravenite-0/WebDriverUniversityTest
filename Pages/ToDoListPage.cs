using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using WebDriverUniversityTest.ListItem;

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
        public ToDoListPage ClickAddItem()
        {
            driver.FindElement(By.Id("plus-icon")).Click();
            return this;
        }

        public int GetTotalCount()
        {
            IList<IWebElement> toDoListItems = driver.FindElements(By.TagName("li"));
            return toDoListItems.Count();
        }

        public int GetCompletedCount()
        {
            IList<IWebElement> toDoListItems = driver.FindElements(By.ClassName("completed"));
            return toDoListItems.Count();
        }

        public void SetNewTask(String taskName)
        {
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("[style='display: none;']"));

            if (elements.Count > 0)
            {
                ClickAddItem();
                new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                   .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.TagName("input")));
            }
            driver.FindElement(By.TagName("input")).SendKeys(taskName + Keys.Enter);
        }

        //Functions dealing with individual list items =======================================================================
        public ToDoListItem GetToDoListItem(String taskName)
        {
            IList<IWebElement> toDoListItems = driver.FindElements(By.TagName("li"));

            foreach (IWebElement toDoListItem in toDoListItems)
            {
                ToDoListItem newItem = new ToDoListItem(toDoListItem, driver);
                if (newItem.GetTaskName().Equals(taskName)) { return newItem; }
            }
            throw new System.ArgumentException("Task " + taskName + " not found!");

        }
    }
}
