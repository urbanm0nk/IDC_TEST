using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September21.Pages;
using September21.Utilities;
using System;
using System.Threading;

namespace September21
{
    [TestFixture]
    class TM_Tests : CommonDriver
    {
       
        [SetUp]
        public void LoginActions()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginAction(driver);


            //Homepage Object initialition and definition
            HomePage HomePageeObj = new HomePage();
            HomePageeObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            // Create New Time and Material record initialization and def
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);
        }

        [Test]
        public void EdithTMTest()
        {
            // Edit Record initialization and definition
            TMPage TMPageObj = new TMPage();
            TMPageObj.EdithTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            // Delete record initialization and def
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTM(driver);


        }

        //[TearDown]
        //public void CloseTestRun()
        //{

        //}
    }

  
}