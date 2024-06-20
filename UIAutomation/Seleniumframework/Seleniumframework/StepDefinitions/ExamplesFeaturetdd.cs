using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Seleniumframework.StepDefinitions
{
    [Binding]
    public class ExamplesFeaturetdd

    {
        private IWebDriver driver;

        public ExamplesFeaturetdd(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Find for (.*)")]
        public void ThenFindForAaa(String search)
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(search);
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
        }



    }
}
