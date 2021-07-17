﻿
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst01
{
    class Program
    {

        //create the reference for our browser
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        
        }

        [SetUp]
        public void Initialize()
        {
            //navigagte to google page

            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

        }

        [Test]
        public void ExecuteTest()
        {
            //Tittle
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Nmae");

            //Click 
            SeleniumSetMethods.Click(driver, "Save", "Name");
            
        }
        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(500);
            driver.Close();

        }
    }
}
