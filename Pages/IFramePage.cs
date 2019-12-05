using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Page_Object_Model;

namespace WebDriverUniversityTest.Pages
{
    class IFramePage : BasePage
    {
        //Constructor ========================================================================================================
        public IFramePage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Iframe Methods =====================================================================================================
        public PageObjectModelPage SwitchFrame()
        { 
            PageObjectModelPage pomPage = new PageObjectModelPage(driver.SwitchTo().Frame(driver.FindElement(By.Id("frame"))));
            driver.SwitchTo().Frame(driver.FindElement(By.Id("frame")));
            return pomPage;
        }

        public IFramePage SwitchParent()
        {
            driver.SwitchTo().ParentFrame();
            return this;
        }
    }
}
