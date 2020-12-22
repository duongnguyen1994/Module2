using NUnit.Framework;
using Shape;

namespace IColorableTest
{
    public class Tests
    {
        private Square square;
        [SetUp]
        public void Setup()
        {
            square = new Square();
        }

        [Test]
        public void TestColorable()
        {
            string expected = "Color all four sides..";
            string result = square.HowToColor();
            Assert.AreEqual(expected, result);
        }
    }
}