using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitDemo.Steps
{

    [Binding]
    public class DemoSteps
    {

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("1ers number");
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("2do number");
        }


        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("sum");
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Console.WriteLine("result");
            //ScenarioContext.Current.Pending();
        }


    }
}
