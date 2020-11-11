using NUnit.Framework;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class Shape_NameShould
    {
        [Test]
        public void Triangle_Name_ReturnCorrectName()
        {
            Triangle triangle = new Triangle(2, 3);

            var result = triangle.Name;

            Assert.AreEqual("Triangle", result);
        }

        [Test]
        public void Rectangle_Name_ReturnCorrectName()
        {
            Rectangle rectangle = new Rectangle(3, 4);

            var result = rectangle.Name;

            Assert.AreEqual("Rectangle", result);
        }

        [Test]
        public void Circle_Name_ReturnCorrectName()
        {
            Circle circle = new Circle(3);

            var result = circle.Name;

            Assert.AreEqual("Circle", result);
        }
    }
}
