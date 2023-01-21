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
    class DashboardPage:BasePage
    {

        [FindsBy(How = How.XPath, Using = "//li[@id='account']")]
        public IWebElement lnkAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@id='account']")]
        public IWebElement lnkUser { get; set; }

        public void clickAccount()
        {
            lnkAccount.Click();
        }
    }
}
