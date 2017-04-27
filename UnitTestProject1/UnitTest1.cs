using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://facebook.com");

            driver.FindElement(By.XPath(".//*[@id='email']")).SendKeys("dddlprojekt@gmail.com");
            driver.FindElement(By.XPath(".//*[@id='pass']")).Click();

            driver.FindElement(By.XPath(".//*[@id='pass']")).SendKeys("Projekt123");
            driver.FindElement(By.XPath(".//*[@id='u_0_s']")).Click();


            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("//textarea[@placeholder='Napisz coś...']")).SendKeys("TestSelenium");

            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@data-testid='react-composer-post-button']")).Click();
        }
    }
}