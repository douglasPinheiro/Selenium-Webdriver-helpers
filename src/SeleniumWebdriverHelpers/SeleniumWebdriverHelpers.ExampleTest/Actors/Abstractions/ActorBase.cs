using OpenQA.Selenium;

namespace SeleniumWebdriverHelpers.ExampleTest.Actors.Abstractions
{
    public abstract class ActorBase
    {
        public string Url
        {
            get
            {
                return "http://address.com.br";
            }
        }

        public static IWebDriver I;
    }
}
