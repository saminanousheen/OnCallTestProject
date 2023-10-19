using OnCallTestProject;
using NUnit.Framework;
using PageObjects;
using System;
using System.Threading;

namespace OnCallTestProject
{
    [TestFixture]
    public class LoginTest : BaseTest
    {

        [Test]
        public void VerifyOnCallLoginFunctionality()
        {

            string username = "GIR";
            string password = "HxGN1";
            OnCallLoginPage LoginPage = new OnCallLoginPage();
            LoginPage.EnteringUnameandPswd(username, password);
            LoginPage.VerifyLoginSuccessful();

        }



    }
}
