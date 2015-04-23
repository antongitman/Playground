using NUnit.Framework;

namespace Playground.StringCalculator
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new StringCalculator();
        }

        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            var result = _calculator.Add("");

            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase("1")]
        [TestCase("2")]
        [TestCase("10")]
        [TestCase("99")]
        public void Add_SingleNumber_ReturnsTheNumber(string numberString)
        {
            var result = _calculator.Add(numberString);

            Assert.That(result,Is.EqualTo(int.Parse(numberString)));
        }

        [TestCase("1,2",3)]
        [TestCase("1,2,3",6)]
        [TestCase("10,20",30)]
        [TestCase("111,222,333",666)]
        public void Add_MultipleNumbers_ReturnsTheSumOfTheNumbers(string numberString,int expected)
        {
            var result = _calculator.Add(numberString);
            Assert.That(result,Is.EqualTo(expected));
        }
}
}
