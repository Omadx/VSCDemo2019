using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitDemo
{
    public class LoginVSC
    {
        public const string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession2;

        [SetUp]
        public void Setup()
        {
            AppiumOptions Options = new AppiumOptions();
            Options.AddAdditionalCapability("app", "{7C5A40EF-A0FB-4BFC-874A-C0F2E0B9FA8E}\\Default Company Name\\My App Login\\CSLoginRegisterForm.exe");
            Options.AddAdditionalCapability("deviceName", "WindowsPc");
            DesktopSession2 = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
            Assert.IsNotNull(DesktopSession2);
            Thread.Sleep(5000);
            //DesktopSession.CloseApp();
        }

        [Test]
        public void ButtonPagoss()
        {
            Console.WriteLine("Test Completed!!!");
        }
        [TearDown]
        public void Close()
        {
            Console.WriteLine("Test Completed2!!!!");
            Thread.Sleep(5000);
        }
    }
}
