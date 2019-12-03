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
    class DropdownCheckboxRadioPageTests : BaseTestSuite
    {
        [Test]
        public void DropdownTest()
        {
            DropdownCheckboxRadioPage dropdownCheckboxRadioPage = new HomePage(driver).ClickDropdownCheckboxRadio();
            dropdownCheckboxRadioPage.SetDropdown(1, "pYtHoN");
            dropdownCheckboxRadioPage.SetDropdown(2, "TESTng");
            dropdownCheckboxRadioPage.SetDropdown(3, "html");

            Assert.AreEqual("Python", dropdownCheckboxRadioPage.GetDropdown(1));
            Assert.AreEqual("TestNG", dropdownCheckboxRadioPage.GetDropdown(2));
            Assert.AreEqual("HTML", dropdownCheckboxRadioPage.GetDropdown(3));
        }

        [Test]
        public void CheckboxTest()
        {
            DropdownCheckboxRadioPage dropdownCheckboxRadioPage = new HomePage(driver).ClickDropdownCheckboxRadio();
            dropdownCheckboxRadioPage.SetCheckbox(1, 3, 4);
            Assert.AreEqual("Option 1, Option 4", dropdownCheckboxRadioPage.GetSelectedCheckbox());
        }

        [Test]
        public void RadioTest()
        {
            DropdownCheckboxRadioPage dropdownCheckboxRadioPage = new HomePage(driver).ClickDropdownCheckboxRadio();
            dropdownCheckboxRadioPage.SetRadio("gReEn");
            dropdownCheckboxRadioPage.SetRadio("PuRpLe");

            Assert.AreEqual("Purple", dropdownCheckboxRadioPage.GetSelectedRadio());

        }

        [Test]
        public void DisabledTest()
        {
            DropdownCheckboxRadioPage dropdownCheckboxRadioPage = new HomePage(driver).ClickDropdownCheckboxRadio();
            Assert.AreEqual("Cabbage",dropdownCheckboxRadioPage.GetDisabledRadio());
            Assert.AreEqual("Orange",dropdownCheckboxRadioPage.GetDisabledDropdown());
        }
    }
}
