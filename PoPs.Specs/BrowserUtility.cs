﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace PoPs.Specs
{
    [Binding]
    public class BrowserUtility
    {
        public static IWebDriver Browser { get; set; }

        [BeforeScenario(@"ResetForEachTest")]
        public void InitTest()
        {
            Browser = new InternetExplorerDriver();
            Browser.Manage().Cookies.DeleteAllCookies();
        }

        [AfterScenario(@"ResetForEachTest")]
        public void FinishTest()
        {
            Browser.Close();
        }
    }
}
