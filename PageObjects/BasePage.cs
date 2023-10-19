using Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class BasePage
    {
        public WebDriverWait wait = new WebDriverWait(DriverManager.driver, TimeSpan.FromSeconds(30));
    }
}

