using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Seleniumframework.StepDefinitions
{
    [Binding]
    public class Datatablestdd

    {
        private IWebDriver driver;

        public Datatablestdd(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"try to find the keyword")]
        public void ThenTryToFindTheKeyword(Table table)
        {
            var searchcriteria = table.CreateSet<searchkeydata>();

            foreach(var keyword in searchcriteria)
            {
                driver.FindElement(By.XPath("//input[@id='search']")).Clear();
                driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(keyword.searchkey);
                driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            }
        }




    }

    public class searchkeydata
    {
        public string searchkey { get; set; }
    }
}
