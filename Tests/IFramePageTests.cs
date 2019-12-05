using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Page_Object_Model;
using WebDriverUniversityTest.Pages;

namespace WebDriverUniversityTest.Tests
{
    [TestFixture]
    class IFramePageTests : BaseTestSuite
    {
        [Test]
        public void TestFrameOperations()
        {
            String title = "SPECIAL OFFER! - GET 30% OFF YOUR FIRST ORDER AT WEBDRIVERUNIVERSITY.COM";

            IFramePage iFramePage = new HomePage(driver).ClickIFrame();

            PageObjectModelPage pomPage = iFramePage.SwitchFrame();
            
            PomProduct pomProduct = pomPage.ClickPomProducts().FindFramesProduct("Cameras");

            Assert.AreEqual(title, pomPage.ClickPomProducts().GetPomDialog(pomProduct).GetTitle());
        }

    }
}
