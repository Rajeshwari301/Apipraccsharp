using BoDi;
using Seleniumframework.Utility;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using AventStack.ExtentReports;


namespace Seleniumframework.Hooks
{
    [Binding]
    public sealed class Hooks :ExtentReport
    {
       private readonly IObjectContainer _container;
       private readonly ISpecFlowOutputHelper _outputHelper;

       public Hooks(IObjectContainer container, ISpecFlowOutputHelper outputhelper)
        {
            _container = container;
            _outputHelper = outputhelper;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("running before test run");
            ExtentReportInit();

        }

        [AfterTestRun]
        public void AfterTestRun()
        {
            Console.WriteLine("running after test run");
            ExtentReportTearDown();

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}