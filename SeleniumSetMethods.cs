using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace SeleniumFirst01
{
    class SeleniumSetMethods
    {
        //EnterText
        public static void EnterText(  IWebElement element, string value)
        {
            element.SendKeys(value);
          //  if (elementtype == PropertyType.Id)
              //  PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
          //  if (elementtype == PropertyType.Name)
               // PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);

        }

        // lick int the button, checkbox,options etc
        public static void Click( IWebElement element)

        {
            element.Click();

           // if (elementtype == PropertyType.Id)
             //   PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            //if (elementtype == PropertyType.Name)
             //   PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        //selecting dropdown control
        public static void SelectDropDown( IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);

            //SelectElement selectElement = new SelectElement()
          // if (elementtype == PropertyType.Id)
              //  new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
         //   if (elementtype == PropertyType.Name)
              //  new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);

        }
    }

}
