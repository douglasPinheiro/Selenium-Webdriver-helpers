﻿using System;
using System.Threading;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Webdriver_Helpers.App
{
    public static class WaitExtensions
    {
        public static void WaitForAjax(this IWebDriver driver)
        {
            while (true)
            {
                var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                    break;
                Thread.Sleep(100);
            }
        }

        public static void WaitElement(this IWebDriver browser, By locator)
        {
            Wait(browser, locator, TimeSpan.FromMinutes(1));
        }

        private static void Wait(IWebDriver browser, By locator, TimeSpan timespan)
        {
            IWait<IWebDriver> wait = new WebDriverWait(browser, timespan);
            wait.Until(d => d.FindElements(locator).Any());
        }
    }
}
