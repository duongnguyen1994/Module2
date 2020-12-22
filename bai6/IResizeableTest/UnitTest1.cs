using NUnit.Framework;
using Shape;

namespace IResizeableTest
{
    public class Tests
    {
        private Circle circle;
        private Rectangle rectangle;
        private Square square;
        [SetUp]
        public void Setup()
        {
            circle = new Circle(5);
            rectangle = new Rectangle(5,10);
            square = new Square(5);
        }

        [Test]
        public void TestCircleResize()
        {
            double percent = 0.5;
            double expected = 5 * 5 * System.Math.PI * 1.5;
            double result = circle.Resize(percent);
            Assert.IsTrue(expected==result);
        }
        [Test]
        public void TestRectangleResize()
        {
            double percent = 1;
            double expected = 5 * 10 * 2;
            double result = rectangle.Resize(percent);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestSquareResize()
        {
            double percent = 2;
            double expected = 5 * 5 * 3;
            double result = square.Resize(percent);
            Assert.AreEqual(expected, result);
        }
    }
}