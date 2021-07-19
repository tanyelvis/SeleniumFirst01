
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
        //IWebPropertiesCollection.PropertiesCollection.driver PropertiesCollection.PropertiesCollection.driver = new ChromePropertiesCollection.PropertiesCollection.driver();
        static void Main(string[] args)
        {
        
        }

        [SetUp]
        public void Initialize()
        {

            PropertiesCollection.driver = new ChromeDriver();
            //navigagte to google page

            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Openned URL");

        }

        [Test]
        public void ExecuteTest()
        {

            //initialise the page by calling its reference

            EAPageObject page = new EAPageObject();
            page.txtInitial.SendKeys("executeautomation");
            page.btnSave.Click();


            //Tittle
            //SeleniumSetMethods.SelectDropDown("TitleId","Mr.",PropertyType.Id);

            //Initial
            //SeleniumSetMethods.EnterText( "Initial", "executeautomation", PropertyType.Name);
            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText( "TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText( "Initial",PropertyType.Name));


            //Click 
            //SeleniumSetMethods.Click( "Save", PropertyType.Name);
            
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }



        [TearDown]
        public void CleanUp()
        {
            //Thread.Sleep(500);
           PropertiesCollection.driver.Close();
           Console.WriteLine("Close Browser");

        }
    }
}
