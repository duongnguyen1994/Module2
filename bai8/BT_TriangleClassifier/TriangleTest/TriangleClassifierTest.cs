using NUnit.Framework;
using Triangle.Service;

namespace TriangleTest
{
    public class TriangleClassifierTest
    {
        private TriangleClassifier triangle;
        [SetUp]
        public void Setup()
        {
            triangle = new TriangleClassifier();
        }

        [Test]
        public void TestEquilateralTriangle()
        {
            int firstEdge = 2;
            int secondEdge = 2;
            int thirdEdge = 2;
            string expected = "Equilateral Triangle";
            string result = triangle.ClassifyTriangle(firstEdge, secondEdge, thirdEdge);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestIsoscelesTriangle()
        {
            int firstEdge = 2;
            int secondEdge = 2;
            int thirdEdge = 3;
            string expected = "Isosceles Triangle";
            string result = triangle.ClassifyTriangle(firstEdge, secondEdge, thirdEdge);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestNormalTriangle()
        {
            int firstEdge = 3;
            int secondEdge = 4;
            int thirdEdge = 5;
            string expected = "Normal Triangle";
            string result = triangle.ClassifyTriangle(firstEdge, secondEdge, thirdEdge);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void IsTriangle()
        {
            int firstEdge = 8;
            int secondEdge = 2;
            int thirdEdge = 3;
            string expected = "This is not a Triangle";
            string result = triangle.ClassifyTriangle(firstEdge, secondEdge, thirdEdge);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestValueOfEdgeUnderZero()
        {
            int firstEdge = -1;
            int secondEdge = 2;
            int thirdEdge = 1;
            string expected = "This is not a Triangle";
            string result = triangle.ClassifyTriangle(firstEdge, secondEdge, thirdEdge);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestValueOfEdgeIsZero()
        {
            int firstEdge = 0;
            int secondEdge = 1;
            int thirdEdge = 1;
            string expected = "This is not a Triangle";
            string result = triangle.ClassifyTriangle(firstEdge, secondEdge, thirdEdge);
            Assert.AreEqual(expected, result);
        }
    }
}