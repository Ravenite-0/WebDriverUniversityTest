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
        public void DropdownTest()
        {
            DropdownCheckboxRadioPage dropdownCheckboxRadioPage = new HomePage(driver).ClickDropdownCheckboxRadio();


        }
    }
}
