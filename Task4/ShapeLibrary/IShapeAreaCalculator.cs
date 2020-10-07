using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public interface IShapeAreaCalculator
    {
        double Calculate(IEnumerable<Shape> shapes);
    }
}
