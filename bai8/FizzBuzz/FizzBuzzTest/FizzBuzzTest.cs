using NUnit.Framework;
using FizzBuzz.Service;

namespace FizzBuzzTest
{
    public class Tests
    {
        private FizzOrBuzz fizzBuzz;
        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzOrBuzz();
        }

        [Test]
        public void GetFizz()
        {
            int number = 33;
            string expected = "Fizz";
            string result = fizzBuzz.IsFizzOrBuzz(number);
            Assert.AreEqual(expected,result);
        }
        [Test]
        public void GetFizzNumberHas3()
        {
            int number = 31;
            string expected = "Fizz";
            string result = fizzBuzz.IsFizzOrBuzz(number);
            Assert.AreEqual(expected,result);
        }
        [Test]
        public void GetBuzz()
        {
            int number = 25;
            string expected = "Buzz";
            string result = fizzBuzz.IsFizzOrBuzz(number);
            Assert.AreEqual(expected,result);
        } 
        [Test]
        public void GetBuzzNumberHas5()
        {
            int number = 52;
            string expected = "Buzz";
            string result = fizzBuzz.IsFizzOrBuzz(number);
            Assert.AreEqual(expected,result);
        }      
        [Test]
        public void GetFizzBuzz()
        {
            int number = 35;
            string expected = "FizzBuzz";
            string result = fizzBuzz.IsFizzOrBuzz(number);
            Assert.AreEqual(expected,result);
        }
        [Test]
        public void GetFizzBuzzNumberHas3And5()
        {
            int number = 533;
            string expected = "FizzBuzz";
            string result = fizzBuzz.IsFizzOrBuzz(number);
            Assert.AreEqual(expected,result);
        }
        [Test]
        public void GetNumber()
        {
            int number = 17;
            string expected = "muoi bay";
            string result = fizzBuzz.IsFizzOrBuzz(number);
            Assert.AreEqual(expected,result);
        }
    }
}