using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Seleniumframework.StepDefinitions
{
    [Binding]
    public class Featurebdd

    {
        private IWebDriver driver;

        public Featurebdd(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
           //driver = new ChromeDriver();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
        }

        [Then(@"Search for testers talk")]
        public void ThenSearchForTestersTalk()
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys("aaa");
            driver.FindElement(By.XPath("//input[@id='searc']")).SendKeys(Keys.Enter);
            //driver.Quit();
        }
    }
}
