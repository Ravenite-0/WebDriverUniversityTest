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
    class PageObjectModelPageTests : BaseTestSuite
    {
        [Test]
        public void TestProductTitle()
        {
            String title = "SPECIAL OFFER! - GET 30% OFF YOUR FIRST ORDER AT WEBDRIVERUNIVERSITY.COM";

            PageObjectModelPage pomPage = new HomePage(driver).ClickPageObjectModel();

            Assert.AreEqual(title, pomPage.ClickPomProducts().GetPomDialog(pomPage.ClickPomProducts().FindProduct("Cameras")).GetTitle());

        }

    }
}
