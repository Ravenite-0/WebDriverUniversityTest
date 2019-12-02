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
    class ButtonsPageTests : BaseTestSuite
    {
        [Test]
        public void TestWebElementClick()
        {
            String test = "Congratulations!";
            ButtonsPage buttonsPage = new HomePage(driver).ClickButtonClicks();
            ButtonDialog dialog = buttonsPage.ClickWebElementButton();
            Assert.AreEqual(test, dialog.GetTitle());
        }

        [Test]
        public void TestJavaScriptClick()
        {
            String test = "It’s that Easy!! Well I think it is.....";
            ButtonsPage buttonsPage = new HomePage(driver).ClickButtonClicks();
            ButtonDialog dialog = buttonsPage.ClickJavaScriptButton();
            Assert.AreEqual(test, dialog.GetTitle());
        }

        [Test]
        public void TestActionClick()
        {
            String test = "Well done! the Action Move & Click can become very useful!";
            ButtonsPage buttonsPage = new HomePage(driver).ClickButtonClicks();
            ButtonDialog dialog = buttonsPage.ClickActionButton();
            Assert.AreEqual(test, dialog.GetTitle());
        }
    }
}
