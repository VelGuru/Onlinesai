using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OnlineSai.PageObject;
using OnlineSai.FrameworkLib;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Threading;

namespace OnlineSai.Testcases
{
    [TestClass]
    public class Login
    {
        [TestInitialize]
        public void start()
        {
            string BrowserType = ConfigurationManager.AppSettings["browser"];
            DriverContext.intiBrowser(BrowserType);
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DriverContext.Driver.Url = ConfigurationManager.AppSettings["url"];
        }

        [TestMethod]
        public void loginScenario()
        {
            string username = ExcelHelper.getTestData("EnvSheet", "loginScenario", "UserName");
            string password = ExcelHelper.getTestData("EnvSheet", "loginScenario", "Password");
            LoginPage loginpage = new LoginPage();
            loginpage.LoginPHP(username,password);
            Thread.Sleep(2000);
            Assert.AreEqual("Dashboard", DriverContext.Driver.Title,"Validation of page title");
            DashboardPage dashboard = new DashboardPage();
            dashboard.clickAccount();

        }

        [TestMethod]
        public void ExcelData()
        {
           

           

        }

        [TestMethod]
        public void Logout()
        {




        }

        [TestCleanup]
        public void wrapdown()
        {
            DriverContext.Driver.Quit();
        }
    }
}
