using Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Framework
{
    public class DriverManager
    {
        [ThreadStatic]
        public static IWebDriver driver;


        public static void StartBrowser()
        {
            string browserType = JSONHelper.GetValue("browserType");

            switch (browserType.ToLower())
            {
                case "chrome":
                    //1. To Start the Browser
                    DriverManager.driver = new ChromeDriver();
                     
                    break;
                case "firefox":
                    //1. To Start the Browser
                    DriverManager.driver = new FirefoxDriver();
                    break;
                case "edge":
                    //1. To Start the Browser
                    DriverManager.driver = new EdgeDriver();
                    break;
            }

            //Implicit waits are always applied one time to the driver instance
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            DriverManager.driver.Manage().Window.Maximize();
        }

    }
}

