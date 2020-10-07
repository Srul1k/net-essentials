using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        private double a;
        private double h;

        public Triangle(double a, double b) : base("Triangle")
        {
            this.a = a;
            this.h = b;
        }

        public override double GetArea()
        {
            return 0.5 * a * h;
        }
    }
}
