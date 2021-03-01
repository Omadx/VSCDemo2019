using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitDemo
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Demo 1");
            driver = new ChromeDriver("C:\\seleniumBrowserDrivers\\chrome");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://duckduckgo.com/");
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}