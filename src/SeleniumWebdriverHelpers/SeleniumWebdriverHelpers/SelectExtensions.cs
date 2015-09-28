using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverHelpers
{
    public static class SelectExtensions
    {
        public static IWebElement SelectElement(this IWebDriver browser, By locator)
        {
            return browser.FindElement(locator);
        }

        public static IEnumerable<IWebElement> SelectElements(this IWebDriver browser, By locator)
        {
            return browser.FindElements(locator);
        }
    }
}
