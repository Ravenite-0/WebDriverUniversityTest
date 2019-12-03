using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Pages;

namespace WebDriverUniversityTest.Tests
{
    [TestFixture]
    class AccordionPageTests : BaseTestSuite
    {
        [Test]
        public void AutomationTextTest()
        {
            String test = "This text has appeared after 5 seconds!";

            AccordionPage accordionPage = new HomePage(driver).ClickAccordion();
            Assert.AreEqual(test, accordionPage.GetClickAccordionText());
        }
    }
}
