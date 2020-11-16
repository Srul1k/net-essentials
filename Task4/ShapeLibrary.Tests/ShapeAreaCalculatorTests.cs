using NUnit.Framework;
using System.Collections.Generic;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class ShapeAreaCalculatorTests
    {
        [Test]
        public void Calculate_MultipleShapesProvided_ReturnsCorrectArea()
        {
            var shapes = new List<Shape>()
            {
                new Triangle(1, 3),
                new Rectangle(2, 4),
                new Circle(3)
            };

            IShapeAreaCalculator calculator = new ShapeAreaCalculator();
            var actualResult = calculator.Calculate(shapes);

            Assert.AreEqual(16.5685835, actualResult, 1e-7);
        }
    }
}
