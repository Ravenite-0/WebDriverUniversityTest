using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Dialogs;

namespace WebDriverUniversityTest.Pages
{
    class AjaxPage : BasePage
    {
        //Constructor ========================================================================================================
        public AjaxPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Page Methods =======================================================================================================
        public AjaxDialog ClickButton()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                   .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("myDiv")));
            driver.FindElement(By.Id("myDiv")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                   .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".modal.fade.in")));
            return new AjaxDialog(driver.FindElement(By.CssSelector(".modal.fade.in")));
        }
    }
}
