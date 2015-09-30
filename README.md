## Selenium-Webdriver-helpers

[![Build Status](https://img.shields.io/appveyor/ci/douglasPinheiro/Selenium-Webdriver-helpers.svg?style=flat-square)](https://ci.appveyor.com/project/douglasPinheiro/Selenium-Webdriver-helpers/)
[![NuGet](https://img.shields.io/nuget/v/Nuget.Core.svg?style=flat-square)](https://www.nuget.org/packages/Selenium-WebDriver-Helpers/2.2.0)
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

Wait methods:
```c#
  browser.WaitElement(By.CssSelector("#id"));

  browser.WaitElementDisappear(By.CssSelector("#id"));

  browser.WaitElementIsInvisible(By.CssSelector("#id"));

  browser.WaitElementIsVisible(By.CssSelector("#id"));
```

Select methods:
```c#
  browser.SelectElement(By.CssSelector("#id"));
  browser.SelectElements(By.CssSelector("tbody > tr"));

  browser.SelectElementByText(By.CssSelector("#id"), "TextToSearch");
  browser.SelectElementsByText(By.CssSelector("tbody > tr"), "TextToSearch");

  browser.SelectElementByAttribute(By.CssSelector(".class"), "id", "1");
  browser.SelectElementaByAttribute(By.CssSelector("tbody > tr"), "name", "douglas");
```

Get Parent:
```c#
  //Return ul element
  browser.SelectElement(By.CssSelector("ul > li#id"))
      .GetParent();
```

Set Text
```c#
  element.SetText("Text");
```

Get Text
```c#
  element.GetText();
```

Without this package
```c#
  //private method
  browser.WaitElement(By.CssSelector("#id"));

  var element = browser.findElement(By.CssSelector("#id"));
  element.Clear();
  element.sendKeys("Text");
```

With this package
```c#
  browser.WaitElement(By.CssSelector("#id"))
    .ClearText()
    .SetText("Text");
```
