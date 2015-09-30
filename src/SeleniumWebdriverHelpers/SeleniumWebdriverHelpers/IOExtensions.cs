using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverHelpers
{
    public static class IOExtensions
    {
        public static IWebElement GetParent(this IWebElement element)
        {
            return element.FindElement(By.XPath(".."));
        }

        public static void SetText(this IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static string GetText(this IWebElement element)
        {
            return element.Text;
        }

        public static IWebElement ClearText(this IWebElement element)
        {
            element.Clear();
            return element;
        }
    }
}
