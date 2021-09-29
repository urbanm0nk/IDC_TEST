using OpenQA.Selenium;
using September21.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace September21.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            //Thread.Sleep(1500);
            createNew.Click();
            

            //locate and click the TypeCode dropdown
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            Thread.Sleep(1500);
            typeCode.Click();
            
            //Select/click the Time option
            IWebElement timeDrop = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            //IWebElement timeDrop = driver.FindElement(By.Id("TypeCode_option_selected"));
            Thread.Sleep(1500);
            timeDrop.Click();


            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Now Ti");

            IWebElement descTextbox = driver.FindElement(By.Id("Description"));
            descTextbox.SendKeys("The time is now 4");

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            //Observe and know why
            IWebElement priceBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceBox.Click();
            priceTextbox.SendKeys("18.333");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(4000);


            //Go to last page
            //IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(2000);

            IWebElement timeRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[8]/td[1] 

            if (timeRecord.Text == "Now Ti")

            {
                Console.WriteLine("The test is successfull");
            }
            else
            {
                Console.WriteLine("The test failed.");

            }
        }

        public void EdithTM(IWebDriver driver)
        {

            //Edit record 
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            driver.FindElement(By.Id("Description")).Clear();
            driver.FindElement(By.Id("Description")).SendKeys("The time is modified 2");
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(4000);
            //Going to the last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);
        }

        public void DeleteTM(IWebDriver driver)
        {

            //Delete Record
            IWebElement delButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delButton.Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
