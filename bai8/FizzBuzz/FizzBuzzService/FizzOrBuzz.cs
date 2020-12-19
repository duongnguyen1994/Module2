using System;

namespace FizzBuzz.Service
{
    public class FizzOrBuzz
    {
        private FizzBuzzTranslate fizzBuzz = new FizzBuzzTranslate();
        public string IsFizzOrBuzz(int number)
        {
            if (number % 15 == 0 ||(Have3InNumber(number)&&Have5InNumber(number)) )
            {
                return "FizzBuzz";
            }
            else
            {
                if (Have3InNumber(number)||number % 3 == 0)
                {
                    return "Fizz";
                }
                if (Have5InNumber(number)||number % 5 == 0)
                {
                    return "Buzz";
                }                              
            }
            return $"{fizzBuzz.TranslateNumber(number)}";
        }
        public bool Have3InNumber(int number)
        {
            if (number % 10 == 3 || (number / 10) % 10 == 3 || number / 100 == 3)
            {
                return true;
            }
            return false;
        }
        public bool Have5InNumber(int number)
        {
            if (number % 10 == 5 || (number / 10) % 10 == 5 || number / 100 == 5)
            {
                return true;
            }
            return false;
        }
    }
}
