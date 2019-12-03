using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebDriverUniversityTest.Pages
{
    class DropdownCheckboxRadioPage : BasePage
    {
        //Constructor ========================================================================================================
        public DropdownCheckboxRadioPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());
        }

        //Dropdown Methods ===================================================================================================
        public void SetDropdownOne(int list,String selection)
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("dropdowm-menu-" + list)));
            try { dropdown.SelectByValue(selection.ToLower()); }
            catch { throw new System.ArgumentException("Option " + selection + " not found in dropbox No." + list); }
        }

        public String GetCurrentDropdownSelection(int list)
        {
            return driver.FindElement(By.Id("dropdowm-menu-" + list)).Text;
        }

        //Checkbox Methods ===================================================================================================
        public void ChangeCheckbox(params int[] options)
        {
            foreach (int option in options) 
            {
                try { driver.FindElement(By.CssSelector("#checkboxes input[value='option-" + option + "']")).Click(); }
                catch { throw new System.ArgumentException("Option " + option + " not found!"); }
            }
        }

        public String GetSelectedCheckbox()
        {
            List<String> checkedcheckboxes = new List<String>();
            IList<IWebElement> checkboxes = driver.FindElements(By.CssSelector("#checkboxes [type='checkbox']"));
            foreach (IWebElement checkbox in checkboxes)
            {
                if (checkbox.Selected)
                {
                    checkedcheckboxes.Add(checkbox.Text);
                }

            }

            if (checkedcheckboxes.Count != 0)
            {
                return checkedcheckboxes.Aggregate((i, j) => i + ", " + j);
            }
            else
            {
                throw new System.ArgumentException("Option not found!");
            }
        }


        //Radio Methods ======================================================================================================
        public void SelectRadioOptions(String option)
        {
            try { driver.FindElement(By.CssSelector("#radio-buttons input[value='" + option.ToLower() + "']")); }
            catch { throw new System.ArgumentException("Option " + option + " not found!"); }
        }

        //Disabled options methods ===========================================================================================
        public void DisableRadioButton(String option)
        {
            //TBC
        }
    }
}
