using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using September21.Pages;
using September21.Utilities;
using System;
using TechTalk.SpecFlow;

namespace September21.StepDefinition
{
    [Binding]
    public class TMFeatureSteps : CommonDriver
    {
        [Given(@"I login to turn up portal successfully")]
        public void GivenILoginToTurnUpPortalSuccessfully()
        {
            //open browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);
        }
        
        [Given(@"I navigate to the time and material page")]
        public void GivenINavigateToTheTimeAndMaterialPage()
        {
            //Homepage Object initialition and definition
            HomePage HomePageeObj = new HomePage();
            HomePageeObj.GoToTMPage(driver);
        }

        [Given(@"I navigate to the time and material record page")]
        public void GivenINavigateToTheTimeAndMaterialRecordPage()
        {
            //Homepage Object initialition and definition
            HomePage HomePageeObj = new HomePage();
            HomePageeObj.GoToTMPage(driver);
        }

        //[Given(@"I select a record by clicking on the edit button for the record")]
        //public void GivenISelectARecordByClickingOnTheEditButtonForTheRecord()
        //{
        //    // Edit Record initialization and definition
        //    //TMPage TMPageObj = new TMPage();
        //    //TMPageObj.EdithTM(driver);
        //}

        //[Given(@"I select a record by clicking on the delete button for the record")]
        //public void GivenISelectARecordByClickingOnTheDeleteButtonForTheRecord()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I navigate to employee details page")]
        //public void GivenINavigateToEmployeeDetailsPage()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I navigate to the employee details page")]
        //public void GivenINavigateToTheEmployeeDetailsPage()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I select a record by clicking on the edit button for the employee")]
        //public void GivenISelectARecordByClickingOnTheEditButtonForTheEmployee()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // Create New Time and Material record initialization and def
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);
        }
        
        //[When(@"I edit the record and save")]
        //public void WhenIEditTheRecordAndSave()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I delete a record")]
        //public void WhenIDeleteARecord()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I create employee record")]
        //public void WhenICreateEmployeeRecord()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[When(@"I edit the details and save")]
        //public void WhenIEditTheDetailsAndSave()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage TMPageObj = new TMPage();
            string newCode = TMPageObj.GetCode(driver);
            string newTypeCode = TMPageObj.GetTypeCode(driver);
            Assert.That(newCode == "Now Ti", "Actual Code and expected code do not match.");
            Assert.That(newTypeCode == "T", "Actual TypeCode and expected tyecode do not match.");
        }
        
        //[Then(@"The record should be updated successfully")]
        //public void ThenTheRecordShouldBeUpdatedSuccessfully()

        //{
        //    TMPage TMPageObj = new TMPage();
        //    string newDescription = TMPageObj.GetDescription(driver);
        //    Assert.That(newDescription == "The time is modified 2", "Actual Decs and expected desc do not match."); 
        //}
        
       //// [Then(@"The record should be successfully deleted")]
       // public void ThenTheRecordShouldBeSuccessfullyDeleted()
       // {
       //     ScenarioContext.Current.Pending();
       // }
        
        //[Then(@"The details should be updated successfully")]
        //public void ThenTheDetailsShouldBeUpdatedSuccessfully()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"The details should be successfully deleted")]
        //public void ThenTheDetailsShouldBeSuccessfullyDeleted()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //Using Scenario Outline

        [When(@"I update '(.*)' on existing time and material record")]
        public void WhenIUpdateOnExistingTimeAndMaterialRecord(string p0)
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.EdithTM(driver, p0);
        }

        [Then(@"The record should have '(.*)' updated successfully")]
        public void ThenTheRecordShouldHaveUpdatedSuccessfully(string p0)
        {
            TMPage TMPageObj = new TMPage();
            Assert.That(TMPageObj.GetDescription(driver) == p0, "Updated record mismatch");
        }




    }
}
