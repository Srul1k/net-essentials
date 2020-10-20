using System.Collections.Generic;

namespace ShapeLibrary
{
    public interface IShapeAreaCalculator
    {
        double Calculate(IEnumerable<Shape> shapes);
    }
}
