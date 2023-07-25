using System;
using TechTalk.SpecFlow;

namespace Apiprac.StepDefinitions
{
    [Binding]
    public class PostRequest
    {
        [Given(@"I send a request with posturl ""([^""]*)""")]
        public void GivenISendARequestWithPosturl(string p0)
        {
            
        }

        [Then(@"The request succeeds with status (.*)")]
        public void ThenTheRequestSucceedsWithStatus(int p0)
        {
            throw new PendingStepException();
        }

    }
}
