using Apiprac.Support;
using Newtonsoft.Json;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Apiprac.StepDefinitions
{
    [Binding]
    public class Putrequest
    { 
        HttpClient httpClient;
        HttpResponseMessage httpResponseMessage;
        string responsebody;
        private readonly ISpecFlowOutputHelper outputHelper;

        public Putrequest(ISpecFlowOutputHelper specFlowOutputHelper)
        {
            httpClient = new HttpClient();
            this.outputHelper = specFlowOutputHelper;
        }

        [Given(@"I send a put request with url ""([^""]*)""")]
        public async Task GivenISendAPutRequestWithUrl(string url)
        {
            putdata putdata = new putdata()
            {
                name = "raji",
                job = "teacher"
            };

            string data = JsonConvert.SerializeObject(putdata);
            var contentdata = new StringContent(data);
            httpResponseMessage = await httpClient.PutAsync(url, contentdata);
            responsebody = await httpResponseMessage.Content.ReadAsStringAsync();
            outputHelper.WriteLine("putresponse is" + responsebody);
        }

        [Then(@"the put request succeeds with status (.*)")]
        public void ThenTheRequestSucceedsWithStatus(int p0)
        {
            Assert.True(httpResponseMessage.IsSuccessStatusCode);
        }


      


    }
}
