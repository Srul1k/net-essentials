using NUnit.Framework;
using System.Collections.Generic;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class ShapeAreaCalculator_CalculateShould
    {
        [Test]
        public void ShapeAreaCalculator_Calculate_ReturnCorrectArea()
        {
            var shapes = new List<Shape>()
            {
                new Triangle(1, 3),
                new Rectangle(2, 4),
                new Circle(3)
            };

            IShapeAreaCalculator calculator = new ShapeAreaCalculator();

            double exceptedResult = 0.0;
            foreach(var s in shapes)
            {
                exceptedResult += s.GetArea();
            }

            var actualResult = calculator.Calculate(shapes);


            Assert.AreEqual(exceptedResult, actualResult);
        }
    }
}
