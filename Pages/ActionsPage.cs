using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.Pages
{
    class ActionsPage : BasePage
    {
        //Constructor ========================================================================================================
        public ActionsPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Dragging Functions =================================================================================================
        public void DragToDrop()
        {
            new Actions(driver).MoveToElement(driver.FindElement(By.Id("draggable"))).ClickAndHold().MoveToElement(driver.FindElement(By.Id("droppable"))).Release().Build().Perform();
            return;
        }

        public String GetDroppableText()
        {
            return driver.FindElement(By.Id("droppable")).Text;
        }

        //Double Clicking Functions ==========================================================================================
        public void DoubleClick()
        {
            new Actions(driver).MoveToElement(driver.FindElement(By.Id("double-click"))).DoubleClick().Build().Perform();
            return;
        }

        public int[] GetColour()
        {
            List<String> rgba = driver.FindElement(By.ClassName("div-double-click")).GetCssValue("background-color").Replace(" ", "").Replace("rgba(", "").Replace(")", "").Split(',').ToList<String>();
            return new int[] { Int32.Parse(rgba[0]), Int32.Parse(rgba[1]), Int32.Parse(rgba[2]), Int32.Parse(rgba[3]) };

        }

        //Hovering Functions =================================================================================================
        public String GetHoverAlert(String position)
        {
            new Actions(driver).MoveToElement(driver.FindElement(By.CssSelector("[style='float:" + position.ToLower() + ";']"))).Build().Perform();

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[style='float:" + position.ToLower() + ";'] .dropdown-content")));

            new Actions(driver).MoveToElement(driver.FindElement(By.CssSelector("[style='float:" + position.ToLower() + ";'] .dropdown-content"))).Click().Build().Perform();

            String alert = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            return alert;
        }

        //Holding Functions ==================================================================================================
        public void HoldButton()
        {
            new Actions(driver).MoveToElement(driver.FindElement(By.Id("click-box"))).ClickAndHold().Build().Perform();
            return;
        }

        public void ReleaseButton()
        {
            if (this.GetHoldText().Equals("Well done! keep holding that click now....."))
            {
                new Actions(driver).MoveToElement(driver.FindElement(By.Id("click-box"))).Release().Build().Perform();
            }
            else
            {
                throw new System.ArgumentException("Please click & hold the button before releasing");
            }
        }

        public String GetHoldText()
        {
            return driver.FindElement(By.Id("click-box")).Text;
        }
    }
}
