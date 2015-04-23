using System;
using NUnit.Framework;
using StoryQ;
using StoryQ.TextualSteps;

namespace Playground.StoryQ
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private Calculator _calculator;
        private int _result;
        private string _numberString;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            
            new Story("A consumer wishes to accumulte a list of numbers contained in a comma delimited string")
            .InOrderTo("sum a comma delimited string of numbeers")
            .AsA("consumer with a number string")
            .IWant("to sum the numbers")

            .WithScenario("the string is empty")
            .Given(WeHaveACalculator)
            .And(WeHaveAnEmptyNumberString)
            .When(WeAddAnEmptyString)
            .Then(TheResultShouldBeZero)
            .ExecuteWithReport();
        }

        private void WeHaveAnEmptyNumberString()
        {
            _numberString = string.Empty;
        }

        private void TheResultShouldBeZero()
        {
            Assert.That(_result,Is.EqualTo(0));
        }

        private void WeAddAnEmptyString()
        {
            _result = _calculator.Add(_numberString);
        }

        private void WeHaveACalculator()
        {
            _calculator = new Calculator();
        }
    }



    public class Calculator
    {
        public int Add(string numberString)
        {
            return 0;
        }
    }
}
