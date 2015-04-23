using System;
using System.Linq;

namespace Playground.StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numberString)
        {
            if(numberString.Any(s => s == Convert.ToChar(",")))
            {
                var numberArray = numberString.Split(Convert.ToChar(","));
                var sum = numberArray.Sum(number => int.Parse(number));
                return sum;
            }

            return IsEmptyString(numberString) ? 0 : int.Parse(numberString);
        }

        private bool IsEmptyString(string numberString)
        {
            return string.IsNullOrEmpty(numberString);
        }
    }
}