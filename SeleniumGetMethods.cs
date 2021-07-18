using OpenQA.Selenium;
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
        public static string GetText(  string element, PropertyType elementtype)
        {
            //NOTE THAT TEXT METHOD DOES NOT WORK FOR ALL CONTROLS
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return string.Empty;

            
        }

        public static string GetTextFromDDL(string element, PropertyType elementtype)
        {
            //NOTE THAT TEXT METHOD DOES NOT WORK FOR ALL CONTROLS
            if (elementtype == PropertyType.Id)

               return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;


        }
    }
}
