using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSai.FrameworkLib
{
    public static class DriverContext
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        public static void intiBrowser(string browserType)
        {
            switch(browserType.ToLower())
            {
                case "chrome":
                    {
                        DriverContext.Driver = new ChromeDriver();
                        DriverContext.Driver.Manage().Window.Maximize();
                    }
                    break;
                case "firefox":
                     {
                         DriverContext.Driver = new FirefoxDriver();
                         DriverContext.Driver.Manage().Window.Maximize();
                     }
                    break;
                case "ie":
                    {
                        DriverContext.Driver = new InternetExplorerDriver();
                        DriverContext.Driver.Manage().Window.Maximize();
                    }
                    break;

            }
        }

    }
}
