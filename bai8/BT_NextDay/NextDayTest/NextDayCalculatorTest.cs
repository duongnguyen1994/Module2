using NUnit.Framework;
using NextDay.Service;

namespace NextDay.Test
{
    public class NextDayCalculatorTest
    {
        public NextDayCalculator _nextDayCalculator;
        [SetUp]
        public void Setup()
        {
            _nextDayCalculator = new NextDayCalculator();
        }

        [Test]
        public void CalculateNormalDay()
        {
            int day = 1;
            int month = 1;
            int year = 2018;
            string expected = "2/1/2018";
            string result = _nextDayCalculator.NextDay(day, month, year);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateLastDayOfMonth31Days()
        {
            int day = 31;
            int month = 1;
            int year = 2018;
            string expected = "1/2/2018";
            string result = _nextDayCalculator.NextDay(day, month, year);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateLastDayOfMonth30Days()
        {
            int day = 30;
            int month = 4;
            int year = 2018;
            string expected = "1/5/2018";
            string result = _nextDayCalculator.NextDay(day, month, year);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateLastDayOfFebuary()
        {
            int day = 28;
            int month = 2;
            int year = 2018;
            string expected = "1/3/2018";
            string result = _nextDayCalculator.NextDay(day, month, year);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateLastDayOfFebuaryInLeapYear()
        {
            int day = 29;
            int month = 2;
            int year = 2020;
            string expected = "1/3/2020";
            string result = _nextDayCalculator.NextDay(day, month, year);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CalculateLastDayOfYear()
        {
            int day = 31;
            int month = 12;
            int year = 2018;
            string expected = "1/1/2019";
            string result = _nextDayCalculator.NextDay(day, month, year);
            Assert.AreEqual(expected, result);
        }
    }
}