using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebElements
{
    public class GetText
    {
        public By Locator { get; set; }


        public GetText(By locator)
        {
            this.Locator = locator;
        }
    }
}
