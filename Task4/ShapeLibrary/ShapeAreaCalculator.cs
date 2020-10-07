﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class ShapeAreaCalculator : IShapeAreaCalculator
    {
        public double Calculate(IEnumerable<Shape> shapes)
        {
            double result = 0;

            foreach (var s in shapes)
                result += s.GetArea();

            return result;
        }
    }
}