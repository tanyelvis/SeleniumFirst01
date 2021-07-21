using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace SeleniumFirst01
{
   public static class SeleniumSetMethods
    {
        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        
            //EnterText
        public static void EnterText( this IWebElement element, string value)
        {
            element.SendKeys(value);
          //  if (elementtype == PropertyType.Id)
              //  PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
          //  if (elementtype == PropertyType.Name)
               // PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);

        }

        /// <summary>
        /// click into a button,checkbox,options,etc
        /// </summary>
        /// <param name="element"></param>

        // lick int the button, checkbox,options etc
        public static void Clicks( this IWebElement element)

        {
            element.Click();

           // if (elementtype == PropertyType.Id)
             //   PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            //if (elementtype == PropertyType.Name)
             //   PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }
       
        
        /// <summary>
        /// selecting a dropdown control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>


        //selecting dropdown control
        public static void SelectDropDown(this  IWebElement element, string value)
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
