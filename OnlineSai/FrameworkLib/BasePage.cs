using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSai.FrameworkLib
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
