using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumframework.Pages
{
    public  class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {  
            this.driver = driver;
        }

        By searchtxtbox = By.XPath("//*[@name='search_query']");

        public ResultPage searchtext(string p0)
        {
            driver.FindElement(searchtxtbox).SendKeys(p0);
            driver.FindElement(searchtxtbox).SendKeys(Keys.Enter);
            return new ResultPage(driver);
        }
    }
}
