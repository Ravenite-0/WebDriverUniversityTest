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
    class ActionsPageTests : BaseTestSuite
    {
        [Test]
        public void FullActionTest()
        {
            ActionsPage actionsPage = new HomePage(driver).ClickActions();
            actionsPage.DragToDrop();
            Assert.AreEqual("Dropped!",actionsPage.GetDroppableText());

            actionsPage.DoubleClick();
            Assert.AreEqual(new int[] {147,203,90,1}, actionsPage.GetColour());

            Assert.AreEqual("Well done you clicked on the link!", actionsPage.GetHoverAlert("Left"));

            actionsPage.HoldButton();
            Assert.AreEqual("Well done! keep holding that click now.....", actionsPage.GetHoldText());

            System.Threading.Thread.Sleep(3000);

            actionsPage.ReleaseButton();
            Assert.AreEqual("Dont release me!!!", actionsPage.GetHoldText());
        }
    }
}
