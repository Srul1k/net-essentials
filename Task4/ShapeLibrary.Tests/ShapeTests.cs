using NUnit.Framework;
using System;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        private static object[] shapesGetAreaCases =
        {
            new object[] { new Triangle(1, 3), 1.5 },
            new object[] { new Rectangle(2, 4), 8 },
            new object[] { new Circle(2), Math.PI },
            new object[] { new Circle(3), 7.06858347 }
        };

        private static object[] shapesNameCases =
        {
            new object[] { new Triangle(1, 3), "Triangle" },
            new object[] { new Rectangle(2, 4), "Rectangle" },
            new object[] { new Circle(2), "Circle" }
        };

        [TestCaseSource("shapesGetAreaCases")]
        public void GetArea_ProvidedDifferentShapeTypes_ReturnsCorrectArea(Shape shape, double expectedArea)
        {
            var actualArea = shape.GetArea();
            Assert.AreEqual(expectedArea, actualArea, 1e-7);
        }

        [TestCaseSource("shapesNameCases")]
        public void Name_ProvidedDifferentShapeTypes_ReturnsCorrectName(Shape shape, string expectedName)
        {
            var actualName = shape.Name;
            Assert.AreEqual(expectedName, actualName);
        }
    }
}