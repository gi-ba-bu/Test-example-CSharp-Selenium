using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;

namespace SeleniumService.Tests;

public class Tests
{
    public IWebDriver? Driver;

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup");
        Driver = new ChromeDriver();
    }

    [Test]
    public void UpdateBioDescriptionWithClick()
    {
        if (Driver is not null)
        {
            Driver.Navigate().GoToUrl("https://gbaldo.netlify.app/");

            var bioInitial = Driver.FindElement(By.XPath("//div[@class = 'paboutme']//p[@id = 'firstsentence']"));
            Assert.AreEqual(bioInitial.Text, "Hello, my name is Giacomo. I'm trying my very best. I have recently completed training as full-stack web developer with Futureproof. That's how I learnt to build websites (such as this one!).");

            Driver.FindElement(By.XPath("//input[@value = 'Shortest']")).Click();
            var bioAfterClick = Driver.FindElement(By.XPath("//div[@class = 'paboutme']//p[@id = 'firstsentence']"));
            Assert.AreEqual(bioAfterClick.Text, "Hello, my name is Giacomo. I'm trying my very best.");
        }
    }


}
