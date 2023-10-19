using Framework;
using Framework.WebElements;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V116.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Label = Framework.WebElements.Label;

namespace PageObjects
{

    public class OnCallLoginPage : BasePage
    {

        TextBox userName = new TextBox(By.XPath("//input[@id='username']"));
        TextBox password = new TextBox(By.XPath("//input[@id='password']"));
        Button Login = new Button(By.XPath("//button[@class='hxgn-button hxgn-button-primary']"));
        Button Continue = new Button(By.XPath("//button[normalize-space()='Continue']"));
        Button toggleSideMenu = new Button(By.XPath("//button[@class='oc-navbar-toggle']"));
        Label OnCallDispatch = new Label(By.XPath("//span[normalize-space()='OnCall Dispatch']"));
        
       
        public void EnteringUnameandPswd(string uname, string pswd)
        {
            Thread.Sleep(10000);
            userName.SetText(uname);
            password.SetText(pswd);
            Login.Click();
            Thread.Sleep(8000);
            Continue.Click();
            Thread.Sleep(10000);
            toggleSideMenu.Click();
            


        }
        public void VerifyLoginSuccessful()
        {
            
           string ExpectedLabel = "HxGN OnCall Dispatch";
            string RuntimeLabel = OnCallDispatch.GetLabelText();
            if (RuntimeLabel.Equals(ExpectedLabel))
                    {
                Console.WriteLine("OnCall dispatch page is opened successfully");
            }
        }

    }
}


