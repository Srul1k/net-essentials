using NUnit.Framework;
using System;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class Shape_GetAreaShould
    {
        [TestCase(3, 6)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        public void Triangle_GetArea_ReturnCorrectResult(double a, double h)
        {
            Triangle triangle = new Triangle(a, h);

            var result = triangle.GetArea();

            Assert.AreEqual(a * h / 2, result);
        }

        [TestCase(3, 6)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        public void Rectangle_GetArea_ReturnCorrectResult(double a, double b)
        {
            Rectangle rectangle = new Rectangle(a, b);

            var result = rectangle.GetArea();

            Assert.AreEqual(a * b, result);
        }

        [TestCase(4)]
        [TestCase(Math.PI)]
        [TestCase(1)]
        public void Circle_GetArea_ReturnCorrectResult(double d)
        {
            Circle circle = new Circle(d);

            var exceptedResult = Math.PI * Math.Pow(d / 2, 2);
            var actualResult = circle.GetArea();

            Assert.AreEqual(exceptedResult, actualResult);
        }
    }
}