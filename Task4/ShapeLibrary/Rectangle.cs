using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangle : Shape
    {
        private double a;
        private double b;

        public Rectangle(double a, double b) : base("Rectangle")
        {
            this.a = a;
            this.b = b;
        }

        public override double GetArea()
        {
            return a * b;
        }
    }
}
