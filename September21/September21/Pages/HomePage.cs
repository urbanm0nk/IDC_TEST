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
    class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            IWebElement AdminTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdminTextbox.Click();
            Wait.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);
            //Thread.Sleep(1500);
            //Wait.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);

            // Open Time and Material

            IWebElement TM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TM.Click();
            Thread.Sleep(1500);


        }
    }
}
