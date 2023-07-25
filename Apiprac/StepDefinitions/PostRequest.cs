using Apiprac.Support;
using Newtonsoft.Json;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Apiprac.StepDefinitions
{
    [Binding]
    public class PostRequest
    { 
        HttpClient httpClient;
        HttpResponseMessage httpResponseMessage;
        string responsebody;
        private readonly ISpecFlowOutputHelper outputHelper;

        public PostRequest(ISpecFlowOutputHelper specFlowOutputHelper)
        {
            httpClient = new HttpClient();
            this.outputHelper = specFlowOutputHelper;
        }


    
        [Given(@"I send a request with posturl ""([^""]*)""")]
        public async Task GivenISendARequestWithPosturl(string url)
        {
            postdata postdata = new postdata()
            {
                name = "raji",
                job = "coder"
            };

            string data = JsonConvert.SerializeObject(postdata);
            var contentdata = new StringContent(data);
            httpResponseMessage = await httpClient.PostAsync(url, contentdata);
           responsebody = await httpResponseMessage.Content.ReadAsStringAsync();
            outputHelper.WriteLine("postresponse is"+responsebody);
        }

        [Then(@"The request succeeds with status (.*)")]
        public void ThenTheRequestSucceedsWithStatus(int p0)
        {
            Assert.True(httpResponseMessage.IsSuccessStatusCode);
        }

    }
}
