using Apiprac.Utils;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Apiprac.StepDefinitions
{
    [Binding]
    public class Getrequest
    { 
       private readonly Baseapi baseapi;
        public Getrequest(ISpecFlowOutputHelper helper)
         {
            baseapi = new Baseapi(helper);
         }
         
        [Given(@"I send a get request with url")]
        public void GivenISendAGetRequestWithUrl()
        {
            baseapi.sendinggetrequest();
        }

        [Then(@"the request succeeds with status code (.*)")]
        public void ThenTheRequestSucceedsWithStatusCode(int p0)
        {
            baseapi.assertgetstatuscode(p0);
        }
    }
}
