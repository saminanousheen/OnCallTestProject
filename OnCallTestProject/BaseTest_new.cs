using Framework;
using Framework.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnCallTestProject
{
    [TestFixture]
    public class BaseTest_new
    {
        [SetUp]
        public void Setup() 
        {
            Console.WriteLine("Setup");

            Console.WriteLine("Starting the CHROME Browser...");
            DriverManager.StartBrowser();
            string url = JSONHelper.GetValue("currentURL");
            DriverManager.driver.Navigate().GoToUrl(url);
        }
        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Closing the Browser...");
            DriverManager.driver.Quit();
            Console.WriteLine("Tear down");
        }

    }
}
