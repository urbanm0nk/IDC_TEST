using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace September21
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            //Thread.Sleep(4000);
            driver.Manage().Window.Maximize();
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1500);
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");

            }
              // From the Admin to edit
            IWebElement AdminTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdminTextbox.Click();
            Thread.Sleep(1500);

            // Open Time and Material

            IWebElement TM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TM.Click();
            Thread.Sleep(1500);

            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            Thread.Sleep(1500);

            //locate and click the TypeCode dropdown
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCode.Click();
            Thread.Sleep(1500);
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

            //Edit record 
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            driver.FindElement(By.Id("Description")).Clear();
            driver.FindElement(By.Id("Description")).SendKeys("The time is modified 2");
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);
            //priceTextbox.Clear();
            //priceTextbox.SendKeys("57.89");
            //Delete Record
            IWebElement delButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delButton.Click();
            driver.SwitchTo().Alert().Accept();



            




        }
    }
}