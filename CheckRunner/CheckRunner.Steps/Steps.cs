using System;
using TechTalk.SpecFlow;

namespace CheckRunner.Steps
{
    [Binding]
    public class Steps
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            Console.WriteLine("GivenTheFirstNumberIs");
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            Console.WriteLine("GivenTheSecondNumberIs");
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("WhenTheTwoNumbersAreAdded");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Console.WriteLine("ThenTheResultShouldBe");
        }
    }
}
