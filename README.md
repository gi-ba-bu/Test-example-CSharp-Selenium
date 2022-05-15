# Testing example using C# and selenium

A simple test written in VSCode using C# and Selenium webdrivers. It tests that the biography length in my personal websites is responsive to a user's click.

## Built using

- [.NET-SDK](https://dotnet.microsoft.com/en-us/download)
- NUnits
- [Selenium.Support](https://www.nuget.org/packages/Selenium.Support/)
- [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver/)
- [Selenium.WebDriver.ChromeDriver](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/)

## Usage

To run the test in VSCode, run `dotnet test`.

## Change Log

- [x] Run `dotnet new sln`
- [x] Create a UI.Tests directory and make this the current directory
- [x] Run `dotnet new nunit`
- [x] Rename UnitTest1.cs to UITest.cs
- [x] Edit the UITest.cs file content
- [x] Install Selenium.Webdriver, Selenium.Support and Selenium.Webdriver.Chrome (compatible to your Chrome version!).
- [x] Test run successfully
