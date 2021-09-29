﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace September21.Utilities
{
    class Wait
    {
        public static void WaitForElementToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {


            var wait = new WebDriverWait(driver, new TimeSpan(0,0, seconds));

            if(locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));

            }

            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));

            }

            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));

            }
        }
    }

}
