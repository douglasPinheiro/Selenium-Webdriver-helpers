using System;
using System.Threading;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriverHelpers
{
    public static class WaitExtensions
    {
        private static TimeSpan _defaultTimeSpan = TimeSpan.FromMinutes(1);

        public static void WaitForAjax(this IWebDriver browser, bool pageHasJQuery = true)
        {
            while (true)
            {
                var ajaxIsComplete = false;

                if (pageHasJQuery)
                    ajaxIsComplete = (bool)(browser as IJavaScriptExecutor).ExecuteScript("if (!window.jQuery) { return false; } else { return jQuery.active == 0; }");
                else
                    ajaxIsComplete = (bool)(browser as IJavaScriptExecutor).ExecuteScript("return document.readyState == 'complete'");

                if (ajaxIsComplete)
                    break;

                Thread.Sleep(100);
            }
        }

        public static IWebElement WaitElement(this IWebDriver browser, By locator)
        {
            Wait(browser, locator, _defaultTimeSpan);
            return browser.SelectElement(locator);
        }

        public static IWebElement WaitElement(this IWebDriver browser, By locator, TimeSpan timeSpan)
        {
            Wait(browser, locator, timeSpan);
            return browser.SelectElement(locator);
        }

        public static IWebElement WaitElementDisappear(this IWebDriver browser, By locator)
        {
            WaitDisappear(browser, locator, _defaultTimeSpan);
            return browser.SelectElement(locator);
        }

        public static IWebElement WaitElementDisappear(this IWebDriver browser, By locator, TimeSpan timeSpan)
        {
            WaitDisappear(browser, locator, timeSpan);
            return browser.SelectElement(locator);
        }

        public static IWebElement WaitElementIsInvisible(this IWebDriver browser, By locator)
        {
            WaitInvisible(browser, locator, _defaultTimeSpan);
            return browser.SelectElement(locator);
        }

        public static IWebElement WaitElementIsInvisible(this IWebDriver browser, By locator, TimeSpan timeSpan)
        {
            WaitInvisible(browser, locator, timeSpan);
            return browser.SelectElement(locator);
        }

        public static IWebElement WaitElementIsVisible(this IWebDriver browser, By locator)
        {
            WaitVisible(browser, locator, _defaultTimeSpan);
            return browser.SelectElement(locator);
        }

        public static IWebElement WaitElementIsVisible(this IWebDriver browser, By locator, TimeSpan timeSpan)
        {
            WaitVisible(browser, locator, timeSpan);
            return browser.SelectElement(locator);
        }

        private static void Wait(IWebDriver browser, By locator, TimeSpan timespan)
        {
            IWait<IWebDriver> wait = new WebDriverWait(browser, timespan);
            wait.Until(d => d.FindElements(locator).Any());
        }

        private static void WaitDisappear(IWebDriver browser, By locator, TimeSpan timespan)
        {
            IWait<IWebDriver> wait = new WebDriverWait(browser, timespan);
            wait.Until(d => d.FindElements(locator).Any() == false);
        }

        private static void WaitInvisible(IWebDriver browser, By locator, TimeSpan timespan)
        {
            IWait<IWebDriver> wait = new WebDriverWait(browser, timespan);
            wait.Until(d => !d.FindElements(locator).Any(e => e.Displayed));
        }

        private static void WaitVisible(IWebDriver browser, By locator, TimeSpan timespan)
        {
            IWait<IWebDriver> wait = new WebDriverWait(browser, timespan);
            wait.Until(d => d.FindElements(locator).Any(e => e.Displayed));
        }
    }
}
