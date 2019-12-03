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
        public void SetDropdown(int list, String selection)
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("dropdowm-menu-" + list)));
            try { dropdown.SelectByValue(selection.ToLower()); }
            catch { throw new System.ArgumentException("Option " + selection + " not found in dropbox No." + list); }
        }

        public String GetDropdown(int list)
        {
            return new SelectElement(driver.FindElement(By.Id("dropdowm-menu-" + list))).SelectedOption.Text;
        }

        //Checkbox Methods ===================================================================================================
        public void SetCheckbox(params int[] options)
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
            IList<IWebElement> checkboxes = driver.FindElements(By.CssSelector("#checkboxes label"));
            foreach (IWebElement checkbox in checkboxes)
            {
                if (checkbox.FindElement(By.CssSelector("input[type='checkbox']")).Selected)
                {
                    checkedcheckboxes.Add(checkbox.GetAttribute("innerText"));
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
        public void SetRadio(String option)
        {
            try { driver.FindElement(By.CssSelector("#radio-buttons input[value='" + option.ToLower() + "']")).Click(); }
            catch { throw new System.ArgumentException("Option " + option + " not found!"); }
        }

        public String GetSelectedRadio()
        {
            IList<IWebElement> radios = driver.FindElements(By.CssSelector("#radio-buttons input[type='radio']"));
            foreach (IWebElement radio in radios)
            {
                if (radio.Selected)
                {
                    string selectedradio = radio.GetAttribute("value").ToLower();
                    return selectedradio.Substring(0, 1).ToUpper() + selectedradio.Substring(1);
                }
            }

            throw new System.ArgumentException("None of the options are selected!");
        }

        //Disabled options methods ===========================================================================================
        public String GetDisabledRadio()
        {
                IList<IWebElement> radios = driver.FindElements(By.CssSelector("#radio-buttons-selected-disabled input[type='radio']"));
                foreach (IWebElement radio in radios)
                {
                    if (!radio.Enabled)
                    {
                        string disabledradio = radio.GetAttribute("value").ToLower();
                        return disabledradio.Substring(0, 1).ToUpper() + disabledradio.Substring(1);
                    }
                }

                throw new System.ArgumentException("None of the options are disabled!");
        }

        public String GetDisabledDropdown()
        {
            IList<IWebElement> options = driver.FindElements(By.CssSelector("#fruit-selects option"));

            foreach (IWebElement option in options)
            {
                if (!option.Enabled)
                {
                    return option.Text;
                }
            }
            throw new System.ArgumentException("None of the options are disabled!");
        }
    }
}
