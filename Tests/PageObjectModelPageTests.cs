﻿using NUnit.Framework;
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
    class PageObjectModelPageTests : BaseTestSuite
    {
        [Test]
        public void TestProductTitle()
        {
            String title = "SPECIAL OFFER! - GET 30% OFF YOUR FIRST ORDER AT WEBDRIVERUNIVERSITY.COM";

            PomProductsPage prodPage = new HomePage(driver).ClickPageObjectModel().ClickPomProducts();

            PomProduct pomProduct = prodPage.FindProduct("Cameras");

            Assert.AreEqual(title, prodPage.GetPomDialog(pomProduct).GetTitle());
        }

    }
}
