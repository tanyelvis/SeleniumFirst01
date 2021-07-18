﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst01
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            //NOTE THAT TEXT METHOD DOES NOT WORK FOR ALL CONTROLS
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return string.Empty;


        }

        public static string GetTextFromDDL(IWebDriver driver, string element, string elementtype)
        {
            //NOTE THAT TEXT METHOD DOES NOT WORK FOR ALL CONTROLS
            if (elementtype == "Id")

               return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;


        }
    }
}
