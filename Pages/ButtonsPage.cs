using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Pages
{
    class ButtonsPage : BasePage
    {
        //Constructor ========================================================================================================
        public ButtonsPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Button Clicks ======================================================================================================
        public ButtonDialog ClickWebElementButton()
        {
            driver.FindElement(By.XPath("//*[@id='button1']")).Click();
            return GetCurrentDialog();
        }

        public ButtonDialog ClickJavaScriptButton()
        {
            driver.FindElement(By.Id("button2")).Click();
            return GetCurrentDialog();
        }

        public ButtonDialog ClickActionButton()
        {
            new Actions(driver).MoveToElement(driver.FindElement(By.Id("button3"))).Click().Build().Perform();
            return GetCurrentDialog();
        }

        //Button Dialog Invocation ===========================================================================================
        private ButtonDialog GetCurrentDialog()
        {
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".modal.fade.in.show")));
            return new ButtonDialog(wait);
        }

    }
}
