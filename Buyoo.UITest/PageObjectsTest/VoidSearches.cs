using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium;
using TestStack.Seleno.Configuration;
using TestStack.Seleno.Configuration.WebServers;
using Buyoo.UITest.PageObjectsTest.PageObjects;
using TestStack.Seleno.PageObjects.Actions;

namespace Buyoo.UITest.PageObjectsTest
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
        }
        
        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
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
            HomePage homePage = Host.Instance.NavigateToInitialPage<HomePage>("http://www.buyoo.com");

            SearchPage searchPage = homePage.SelectCategory(Category.AllDepartments).Search();

            searchPage.WaitFor.AjaxCallsToComplete(new TimeSpan(0, 0, 60));

            Assert.IsTrue(searchPage.ExistsResults());
        }

        [TestMethod]
        public void AmazonInstantVideoVoidSearch()
        {
            HomePage homePage = Host.Instance.NavigateToInitialPage<HomePage>("/");

            SearchPage searchPage = homePage.SelectCategory(Category.AmazonInstantVideo).Search();

            searchPage.WaitFor.AjaxCallsToComplete(new TimeSpan(0, 0, 60));

            Assert.IsTrue(searchPage.ExistsResults());
        }

        [TestMethod]
        public void AppliancesVoidSearch()
        {
            HomePage homePage = Host.Instance.NavigateToInitialPage<HomePage>("http://www.buyoo.com");

            SearchPage searchPage = homePage.SelectCategory(Category.Appliances).Search();

            searchPage.WaitFor.AjaxCallsToComplete(new TimeSpan(0, 0, 60));

            Assert.IsTrue(searchPage.ExistsResults());
        }

        [TestMethod]
        public void AppForAndroidVoidSearch()
        {
            HomePage homePage = Host.Instance.NavigateToInitialPage<HomePage>("http://www.buyoo.com");

            SearchPage searchPage = homePage.SelectCategory(Category.AppsForAndroid).Search();

            searchPage.WaitFor.AjaxCallsToComplete(new TimeSpan(0, 0, 60));

            Assert.IsTrue(searchPage.ExistsResults());
        }

        [TestMethod]
        public void ArtsCrafsAndSewingVoidSearch()
        {
            HomePage homePage = Host.Instance.NavigateToInitialPage<HomePage>("http://www.buyoo.com");

            SearchPage searchPage = homePage.SelectCategory(Category.ArtsCraftsAndSewing).Search();

            searchPage.WaitFor.AjaxCallsToComplete(new TimeSpan(0, 0, 60));

            Assert.IsTrue(searchPage.ExistsResults());
        }

        [TestMethod]
        public void AutomotiveVoidSearch()
        {
            HomePage homePage = Host.Instance.NavigateToInitialPage<HomePage>("http://www.buyoo.com");

            SearchPage searchPage = homePage.SelectCategory(Category.Automotive).Search();

            searchPage.WaitFor.AjaxCallsToComplete(new TimeSpan(0, 0, 60));

            Assert.IsTrue(searchPage.ExistsResults());
        }


    }
}
