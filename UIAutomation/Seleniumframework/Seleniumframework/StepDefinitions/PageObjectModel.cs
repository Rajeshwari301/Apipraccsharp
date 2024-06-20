using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Seleniumframework.Pages;
using System;
using TechTalk.SpecFlow;

namespace Seleniumframework.StepDefinitions
{
    [Binding]
    public class PageObjectModel

    {
        private IWebDriver driver;
        SearchPage search;
        ResultPage result;
        ChannelPage channel;

        public PageObjectModel(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the youtube URL")]
        public void GivenEnterTheYoutubeURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(4000);
        }

        [When(@"Search for testers talk in youtube")]
        public void WhenSearchForTestersTalkInYoutube()
        {
             search = new SearchPage(driver);
             result = search.searchtext("testers talk");
            Thread.Sleep(4000);
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
            channel = result.clickonChannel();
            Thread.Sleep(1000);
        }

        [Then(@"Verify the title of the page")]
        public void ThenVerifyTheTitleOfThePage()
        {
            Assert.Equal("Testers Talk - YouTube", channel.getTitle());
        }



    }
}
