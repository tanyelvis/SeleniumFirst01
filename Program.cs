using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            driver.Navigate().GoToUrl("https://www.google.com");

        }

        [Test]
        public void ExecuteTest()
        {
            //find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //perform operation
            element.SendKeys("execute  automation");

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
    }
}
