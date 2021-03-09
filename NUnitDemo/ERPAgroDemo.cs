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
        public WindowsDriver<WindowsElement> DesktopSession2;

        [SetUp]
        public void Setup()
        {
            AppiumOptions Options = new AppiumOptions();
            Options.AddAdditionalCapability("app", "C:\\Hispatec\\ERPagro\\ERPCerco.exe");
            Options.AddAdditionalCapability("deviceName", "WindowsPc");
            DesktopSession2 = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
            Assert.IsNotNull(DesktopSession2);
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

        [Test]
        public void ButtonPagos()
        {
            Console.WriteLine("Test Completed!!!");
        }
        //[Test]
        //public void HelloERPAgro()
        //{
        //    WindowsElement PagosA = DesktopSession2.FindElementByAccessibilityId("panel1");
        //    PagosA.Click();
        //    WindowsElement PagosB = DesktopSession2.FindElementByAccessibilityId("btnAceptar");
        //    PagosB.Click();
        //    Console.WriteLine(" ");
        //}
        [TearDown]
        public void Close()
        {
            Console.WriteLine("Test Completed2!!!!");
            Thread.Sleep(5000);
            //DesktopSession.CloseApp();
        }
    }
}
