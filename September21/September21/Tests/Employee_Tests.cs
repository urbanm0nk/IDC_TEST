using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using September21.Pages;
using September21.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace September21.Tests
{
    
        [TestFixture]
        [Parallelizable]
        class Employee_Tests : CommonDriver
        {

            [Test, Order(1), Description("Check if user is able to create Employee record with valid data")]
            public void CreateEmployeeTest()
            {

                //driver = new ChromeDriver();
            // Home page object initialization and definition
                HomePage homePageObj = new HomePage();
                homePageObj.GoToEmployeePage(driver);

                // TM page object initialization and definition
                EmployeesPage employeeObj = new EmployeesPage();
                employeeObj.CreateEmployee(driver);
            }
            [Test, Order(2), Description("Check if user is able to edit Employee record with valid data")]
            public void EditEmployeeTest()
            {
                // Home page object initialization and definition
                HomePage homePageObj = new HomePage();
                homePageObj.GoToEmployeePage(driver);

                // Edit time
                EmployeesPage employeeObj = new EmployeesPage();
                employeeObj.EditEmployee(driver);
            }

            [Test, Order(3), Description("Check if user is able to delete Employee record")]
            public void DeleteEmployeeTest()
            {
                // Home page object initialization and definition
                HomePage homePageObj = new HomePage();
                homePageObj.GoToEmployeePage(driver);

                // Delete time
                EmployeesPage employeeObj = new EmployeesPage();
                employeeObj.DeleteEmployee(driver);
            }

        }
    }

