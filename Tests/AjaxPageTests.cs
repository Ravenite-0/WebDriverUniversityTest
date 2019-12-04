using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityTest.Dialogs;
using WebDriverUniversityTest.Pages;

namespace WebDriverUniversityTest.Tests
{
    [TestFixture]
    class AjaxPageTests : BaseTestSuite
    {
        [Test]
        public void AjaxDialogTest()
        {
            AjaxDialog ajaxDialog = new HomePage(driver).ClickAjaxLoader().clickButton();
            Assert.AreEqual("Well Done For Waiting....!!!", ajaxDialog.GetTitle());
        }

    }
}
