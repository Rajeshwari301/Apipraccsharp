using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Apiprac.Hooks
{
    [Binding]
    public class Hooks1
    {
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public Hooks1(ISpecFlowOutputHelper OutputHelper) 
        {
            _OutputHelper = OutputHelper;
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            _OutputHelper.WriteLine("Hooks invoked before scenario");
        }

        [AfterScenario]
        public void FirstBeforeScenario()
        {
            _OutputHelper.WriteLine("Hooks invoked after scenario");
        }

        
    }
}