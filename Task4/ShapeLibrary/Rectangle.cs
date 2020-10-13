using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangle : Shape
    {
        private double A { get; }
        private double B { get; }

        public Rectangle(double a, double b) : base("Rectangle")
        {
            A = a;
            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }
    }
}
