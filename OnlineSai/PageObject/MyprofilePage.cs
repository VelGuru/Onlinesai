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
    class MyprofilePage:BasePage
    {

        [FindsBy(How=How.XPath,Using="//input[@name ='fname']")]
        public IWebElement txtFirstname{get;set;}

        [FindsBy(How=How.Name,Using="lname")]
        public IWebElement txtLastname{get;set;}

    }
}
