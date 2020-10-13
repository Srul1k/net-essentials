using System;
using System.Collections.Generic;
using ShapeLibrary;

namespace ExamplesOfCases
{
    class Program
    {
        static void Main()
        {
			IShapeAreaCalculator areaCalculator = new ShapeAreaCalculator();

			var shapes = new List<Shape>
			{
				new Triangle(2, 3),      // area = 3
				new Circle(4),           // area = 12,5663706
				new Rectangle(2, 3.5)    // area = 7
			};

			areaCalculator.Calculate(shapes); // 22.5663706

			Console.WriteLine(shapes[0].Name); // Triangle
		}
    }
}
