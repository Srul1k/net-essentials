using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        private double d;
        public Circle(double d) : base("Circle")
        {
            this.d = d;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(d / 2, 2);
        }
    }
}
