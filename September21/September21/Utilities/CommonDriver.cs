using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September21.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace September21.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginAction()
        {

            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);
        }


        [OneTimeTearDown]
        public void CloseTestRun() 

        {
            driver.Quit();
        }


    }
}
