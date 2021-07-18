using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst01
{

    enum PropertyType
    {
        Id,
        Name,
        LinkTest,
        CssName,
        ClassName
    }
    class PropertiesCollection
    {

       
        //Auto implemented property
        public static IWebDriver driver { get; set; }
    }
}
