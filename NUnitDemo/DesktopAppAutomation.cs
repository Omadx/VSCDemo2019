using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitDemo
{
    class DesktopAppAutomation
    {
        public const string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;

        [SetUp]
        public void Setup()
        {
            AppiumOptions Options = new AppiumOptions();
            Options.AddAdditionalCapability("app", "C:\\WINDOWS\\system32\\notepad.exe");
            Options.AddAdditionalCapability("deviceName", "WindowsPc");
            DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
            Assert.IsNotNull(DesktopSession);
        }
        [Test, Order(1)]
        public void HelloNotepad()
        {
            WindowsElement NotepadTextArea = DesktopSession.FindElementByAccessibilityId("15");
            NotepadTextArea.SendKeys("Hello World");
        }

        [Test, Order(2)]
        public void ReplaceWorld()
        {
            WindowsElement NotepadTextArea = DesktopSession.FindElementByAccessibilityId("15");
            NotepadTextArea.SendKeys("Hello World");
            WindowsElement EditButton = DesktopSession.FindElementByName("Edición");
            EditButton.Click();
            WindowsElement ReplaceButton = DesktopSession.FindElementByAccessibilityId("23");
            ReplaceButton.Click();
            WindowsElement FindWhatInput = DesktopSession.FindElementByAccessibilityId("1152");
            FindWhatInput.Clear();
            FindWhatInput.SendKeys("World");
            WindowsElement ReplaceWithInput = DesktopSession.FindElementByAccessibilityId("1153");
            ReplaceWithInput.Clear();
            ReplaceWithInput.SendKeys("QA Engineers");
            WindowsElement ReplaceAllButton = DesktopSession.FindElementByName("Reemplazar todo");
            ReplaceAllButton.Click();
            WindowsElement CancelButton = DesktopSession.FindElementByAccessibilityId("2");
            CancelButton.Click();
            Assert.AreEqual("Hello QA Engineers", NotepadTextArea.Text);
            Console.WriteLine("Todo correcto!!!");
        }

        [Test, Order(3)]
        public void EnterTimeAndDataTest()
        {
            WindowsElement EditButton = DesktopSession.FindElementByName("Edición");
            EditButton.Click();
            WindowsElement GetDate = DesktopSession.FindElementByAccessibilityId("26");
            GetDate.Click();
            string value = DesktopSession.FindElementByName("Editor de texto").GetAttribute("Value.Value");
            Console.WriteLine(value);
            Assert.IsTrue(value.Contains("2021"));
            Console.WriteLine("Test Completed!!!");
        }


        //[Test]
        //public void CloseNote()
        //{
        //    WindowsElement PanelClose = DesktopSession.FindElementByName("Bloc de notas");
        //    PanelClose.Click();
        //    WindowsElement NoButton = DesktopSession.FindElementByName("No guardar");
        //    NoButton.Click();
        //}

        [TearDown]
        public void Close()
        {
            DesktopSession.CloseApp();
        }
    }
}
