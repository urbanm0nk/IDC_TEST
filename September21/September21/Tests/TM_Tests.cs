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
    [Parallelizable]
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

        [Test, Order(1), Description("Check if user is able to create Time record with valid data")]
        public void CreateTMTest()
        {
            // Create New Time and Material record initialization and def
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit Time record with valid data")]
        public void EdithTMTest()
        {
            // Edit Record initialization and definition
            TMPage TMPageObj = new TMPage();
            TMPageObj.EdithTM(driver, "dummy");
        }

        [Test, Order(3), Description("Check if user is able to delete Material record")]
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