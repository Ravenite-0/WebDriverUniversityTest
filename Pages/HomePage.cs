using OpenQA.Selenium;
using WebDriverUniversityTest.IFrames;

namespace WebDriverUniversityTest.Pages
{
    class HomePage : BasePage
    {
        //Constructor ========================================================================================================
        public HomePage(IWebDriver driver) : base(driver) { }

        //IFrame =============================================================================================================
        public Video LoadHomePageVideoIFrame()
        {
            return new Video(driver.FindElement(By.Id("udemy-promo-thumbnail")));
        }

        //Navigation to pages ================================================================================================
        public void ClickContactUs()
        {
            driver.FindElement(By.CssSelector("#contact-us .thumbnail")).Click();
        }

        public void ClickLoginPortal()
        {
            driver.FindElement(By.CssSelector("#login-portal .thumbnail")).Click();
        }

        public ButtonsPage ClickButtonClicks()
        {
            driver.FindElement(By.CssSelector("#button-clicks .thumbnail")).Click();
            return new ButtonsPage(driver);
        }

        public ToDoListPage ClickToDoList()
        {
            driver.FindElement(By.CssSelector("#to-do-list .thumbnail")).Click();
            return new ToDoListPage(driver);
        }

        public void ClickPageObjectModel()
        {
            driver.FindElement(By.CssSelector("#page-object-model .thumbnail")).Click();
        }

        public void ClickAccordion()
        {
            driver.FindElement(By.CssSelector("[href = 'Accordion/index.html'].thumbnail")).Click();
        }

        public void ClickDropdownCheckboxRadio()
        {
            driver.FindElement(By.CssSelector("#dropdown-checkboxes-radiobuttons .thumbnail")).Click();
        }

        public void ClickAjaxLoader()
        {
            driver.FindElement(By.CssSelector("#ajax-loader .thumbnail")).Click();
        }

        public void ClickPopUpAlerts()
        {
            driver.FindElement(By.CssSelector("#popup-alerts .thumbnail")).Click();
        }

        public void ClickIFrame()
        {
            driver.FindElement(By.CssSelector("#iframe .thumbnail")).Click();
        }

        public void ClickHiddenElements()
        {
            driver.FindElement(By.CssSelector("#hidden-elements .thumbnail")).Click();
        }

        public void ClickDataTable()
        {
            driver.FindElement(By.CssSelector("#data-table .thumbnail")).Click();
        }
    }
}
