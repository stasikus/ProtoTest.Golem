﻿using MbUnit.Framework;
using Golem.PageObjects.Google;
using ProtoTest.Golem.WebDriver;

namespace Golem.Tests.Google
{
    [TestFixture]
    public class GoogleTest : WebDriverTestBase
    {
        [Test]
        public static void TestSearch()
        {
           GoogleHomePage.OpenGoogle().VerifyImages();
        }

        [Test]
        [Row("Selenium", "Selenium - Web Browser Automation")]
        [Row("ProtoTest", "ProtoTest - IT Staffing and Mobile App Testing Lab")]
        [Row("Soasta", "SOASTA - Wikipedia, the free encyclopedia")]
        public void TestSearch_WithRows(string searchText, string searchResult)
        {
            GoogleHomePage.
                OpenGoogle().
                SearchFor(searchText).
                VerifyResult(searchResult).
                GoToResult(searchResult);
        }
        
    }
}