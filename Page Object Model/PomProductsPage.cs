using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Dialogs;
using WebDriverUniversityTest.Pages;

namespace WebDriverUniversityTest.Page_Object_Model
{
    class PomProductsPage : PageObjectModelPage
    {
        //Constructor ========================================================================================================
        public PomProductsPage(IWebDriver driver) : base(driver) {}

        //Page functionalities ===============================================================================================
        public PomDialog GetPomDialog(PomProduct pomProduct)
        {
            pomProduct.ClickProduct();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".modal.fade.in")));
            return new PomDialog(wait);
        }

        public PomProduct FindProduct(String productName)
        {
            IList<IWebElement> products = driver.FindElements(By.CssSelector("[data-toggle='modal']"));
            foreach (IWebElement product in products) {
                PomProduct pomProduct = new PomProduct(product);
                if(pomProduct.GetProductName().Equals(productName)) { return pomProduct; }
            }
            throw new System.ArgumentException("Product " + productName + " not found!");
        }
    }
}
