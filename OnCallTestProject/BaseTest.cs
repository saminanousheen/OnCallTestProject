using Framework;
using Framework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnCallTestProject
{
    [TestFixture]
    public class BaseTest
    {
        [SetUp] //This gets executed before Test
        public void Setup()
        {
            Console.WriteLine("Setup");

            Console.WriteLine("Starting the CHROME Browser...");
            
            DriverManager.StartBrowser();
            string url = JSONHelper.GetValue("currentURL");
            //2. Navigate to the Website
            DriverManager.driver.Navigate().GoToUrl(url);

        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing the Browser...");
            DriverManager.driver.Quit();
            Console.WriteLine("Tear down");
        }
    }
}

