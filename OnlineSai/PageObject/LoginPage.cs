using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineSai.FrameworkLib;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSai.PageObject
{
    class LoginPage : BasePage
    {

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtEmail { get;set;}

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement btnLogin { get; set; }

        public void LoginPHP(string username,string password)
        {
            txtEmail.SendKeys(username);
            txtPassword.SendKeys(password);
            Assert.IsTrue(btnLogin.Displayed);
            btnLogin.Click();
            Assert.Fail();
            StringAssert.StartsWith("Assert", "As");
        }
    }
}
