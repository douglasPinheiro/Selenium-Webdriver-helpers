using System.Threading;
using OpenQA.Selenium;

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
    }
}
