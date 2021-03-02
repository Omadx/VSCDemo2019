using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitDemo
{
    public class ERPAgroDemo
    {
        public const string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;

        [SetUp]
        public void Setup()
        {
            AppiumOptions Options = new AppiumOptions();
            Options.AddAdditionalCapability("app", "C:\\Hispatec\\ERPagro\\ERPCerco.exe");
            Options.AddAdditionalCapability("deviceName", "WindowsPc");
            DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
            Assert.IsNotNull(DesktopSession);
            Thread.Sleep(5000);
            //DesktopSession.CloseApp();
        }
        //[SetUp]
        //public void SetupEXE()
        //{
        //    AppiumOptions Options = new AppiumOptions();
        //    Options.AddAdditionalCapability("app", "C:\\Hispatec\\ERPagro\\ERPCerco.exe");
        //    Options.AddAdditionalCapability("deviceName", "WindowsPc");
        //    DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
        //    Assert.IsNotNull(DesktopSession);
        //}

        //[Test]
        //public void ButtonPagos()
        //{
        //    WindowsElement PagosB = DesktopSession.FindElementByName("Pagos");
        //    PagosB.Click();
        //}b
        [Test]
        public void HelloERPAgro()
        {
            //WindowsElement PagosB = DesktopSession.FindElementByName("Cancelar");
            //PagosB.Click();
            Console.WriteLine("Test Completed!!!!");
        }
        [TearDown]
        public void Close()
        {
            Console.WriteLine("Test Completed2!!!!");
            //Thread.Sleep(5000);
            //DesktopSession.CloseApp();
        }
    }
}
