using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium;

namespace Buyoo.UITest.BrittleTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class VoidSearches
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext) 
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.buyoo.com";
        }
        
        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            driver.Quit();
        }

        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        static FirefoxDriver driver;
        static string baseURL;

        [TestMethod]
        public void AllDepartmentVoidSearch()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("departmentButton")).Click();
            driver.FindElement(By.CssSelector("li[value=\"1\"] > label")).Click();
            driver.FindElement(By.Id("search-button")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(driver, By.XPath("//article[@class='Wall']"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void AmazonInstantVideoVoidSearch()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("departmentButton")).Click();
            driver.FindElement(By.CssSelector("li[value=\"2\"] > label")).Click();
            driver.FindElement(By.Id("search-button")).Click();

            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(driver, By.XPath("//article[@class='Wall']"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void AppliancesVoidSearch()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("departmentButton")).Click();
            driver.FindElement(By.CssSelector("li[value=\"3\"] > label")).Click();
            driver.FindElement(By.Id("search-button")).Click();

            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(driver, By.XPath("//article[@class='Wall']"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void AppForAndroidVoidSearch()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("departmentButton")).Click();
            driver.FindElement(By.CssSelector("li[value=\"4\"] > label")).Click();
            driver.FindElement(By.Id("search-button")).Click();

            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(driver, By.XPath("//article[@class='Wall']"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void ArtsCrafsAndSewingVoidSearch()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("departmentButton")).Click();
            driver.FindElement(By.CssSelector("li[value=\"5\"] > label")).Click();
            driver.FindElement(By.Id("search-button")).Click();

            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(driver, By.XPath("//article[@class='Wall']"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void AutomotiveVoidSearch()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("departmentButton")).Click();
            driver.FindElement(By.CssSelector("li[value=\"3\"] > label")).Click();
            driver.FindElement(By.Id("search-button")).Click();

            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(driver, By.XPath("//article[@class='Wall']"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        private bool IsElementPresent(OpenQA.Selenium.IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }
    }
}
