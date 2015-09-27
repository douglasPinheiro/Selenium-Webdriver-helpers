## Selenium-Webdriver-helpers

[![Build Status](https://img.shields.io/appveyor/ci/douglasPinheiro/Selenium-Webdriver-helpers.svg?style=flat-square)](https://ci.appveyor.com/project/douglasPinheiro/Selenium-Webdriver-helpers/)
[![NuGet](https://img.shields.io/nuget/v/Nuget.Core.svg?style=flat-square)](https://www.nuget.org/packages/Selenium-WebDriver-Helpers/1.1.0)
[![GitHub license](https://img.shields.io/github/license/mashape/apistatus.svg?style=flat-square)](http://opensource.org/licenses/MIT)

Helpers for Selenium WebDriver

```powershell

Install-Package Selenium-WebDriver-Helpers
```

After install the package, add the assembly reference

```c#
  using SeleniumWebdriverHelpers;
```

Wait For Ajax:
```c#
  var browser = new ChromeDriver();
  browser.WaitForAjax();
```

Wait Element:
```c#
  browser.WaitElement(By.CssSelector("#id"));
```

Select Element
```c#
  browser.SelectElement(By.CssSelector("#id"));
```

Set Text
```c#
  element.SetText("Text");
```

# developing
