using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        private double D { get; }
        public Circle(double d) : base("Circle")
        {
            D = d;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(D / 2, 2);
        }
    }
}
