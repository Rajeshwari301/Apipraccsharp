using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Seleniumframework.StepDefinitions
{
    [Binding]
    public class Featuretdd

    {
        private IWebDriver driver;

        public Featuretdd(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search for '([^']*)'")]
        public void ThenSearchFor(string p0)
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(p0);
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
        }


    }
}
