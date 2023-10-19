using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebElements
{
    public class TextBox
    {
        // click
        //get the text
        //enabled or disabled
        // visible or not

        public By Locator { get; set; }


        public TextBox(By locator)
        {
            this.Locator = locator;
        }
        public void SetText(string text, bool isAutofill = false)
        {
            ElementUtil.SetText(Locator, text);
            if (isAutofill)
            {
                var by = new ByChained(Locator, By.XPath("./../following-sibling::div//div[text()='" + text + "']"));
                ElementUtil.Click(by);
            }
        }

    }
}

