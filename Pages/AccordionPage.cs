using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Pages
{
    class AccordionPage : BasePage
    {
        //Constructor ========================================================================================================
        public AccordionPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Button Clicks ======================================================================================================
        public String GetManualText()
        {
            driver.FindElement(By.Id("manual-testing-accordion")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("button.active#manual-testing-accordion")));
            return driver.FindElement(By.Id("manual-testing-description")).Text;
        }

        public String GetCucumberText()
        {
            driver.FindElement(By.Id("cucumber-accordion")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("button.active#cucumber-accordion")));
            return driver.FindElement(By.Id("cucumber-testing-description")).Text;
        }

        public String GetAutomationText()
        {
            driver.FindElement(By.Id("automation-accordion")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("button.active#automation-accordion")));
            return driver.FindElement(By.Id("automation-testing-description")).Text;
        }

        public String GetClickAccordionText()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .TextToBePresentInElementLocated(By.Id("hidden-text"), "LOADING COMPLETE."));
            driver.FindElement(By.Id("click-accordion")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementIsVisible(By.CssSelector("button.active#click-accordion")));
            return driver.FindElement(By.Id("timeout")).Text;
        }
    }
}
