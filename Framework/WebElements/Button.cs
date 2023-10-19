using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebElements
{
    /// <summary>
    /// Wrapper Class over Button WebElement
    /// </summary>
    public class Button
    {
        public By Locator { get; set; }


        public Button(By locator)
        {
            this.Locator = locator;
        }



        //click
        public void Click()
        {
            ElementUtil.Click(Locator);
        }
        //get the text
        //enabled or disabled
        // visible or not




    }
}
