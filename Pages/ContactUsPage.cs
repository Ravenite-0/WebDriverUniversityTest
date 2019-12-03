using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Pages
{
    class ContactUsPage : BasePage
    {
        //Constructor ========================================================================================================
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }
    }
}
