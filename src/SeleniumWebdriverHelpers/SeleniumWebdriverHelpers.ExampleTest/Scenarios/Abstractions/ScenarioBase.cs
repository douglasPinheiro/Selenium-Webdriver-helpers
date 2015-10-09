using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Safari;
using SeleniumWebdriverHelpers.ExampleTest.Actors.Abstractions;
using System.Diagnostics;

namespace SeleniumWebdriverHelpers.ExampleTest.Scenarios.Abstractions
{
    public abstract class ScenarioBase
    {
        public ScenarioBase()
        {
            Debug.Listeners.Add(new DefaultTraceListener());
            var browser = "Chrome";

            if (browser == "Chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("chrome.switches", "--disable-extensions");

                ActorBase.I = new ChromeDriver(options);
                var opts = ActorBase.I.Manage();
                opts.Window.Maximize();
            }
            else if (browser == "IE")
            {
                ActorBase.I = new InternetExplorerDriver();
                var opts = ActorBase.I.Manage();
                opts.Window.Maximize();
            }
            else if (browser == "Firefox")
            {
                ActorBase.I = new FirefoxDriver();
                var opts = ActorBase.I.Manage();
                opts.Window.Maximize();
            }

            else if (browser == "Safari")
            {
                ActorBase.I = new SafariDriver();
                var opts = ActorBase.I.Manage();
                opts.Window.Maximize();
            }
            else if (browser == "PhantomJS")
            {
                var driverService = PhantomJSDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;

                ActorBase.I = new PhantomJSDriver(driverService);
                var opts = ActorBase.I.Manage();
                opts.Window.Maximize();
            }
        }
    }
}
