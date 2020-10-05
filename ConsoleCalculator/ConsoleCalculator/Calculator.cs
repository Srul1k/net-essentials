using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class Calculator
    {
        public static void Solve(string a, string b, string operation)
        {
            if (CalculatorHelper.DoubleTryParseWithSpecificRange(a, out double x) &&
                CalculatorHelper.DoubleTryParseWithSpecificRange(b, out double y))
            {
                switch (operation)
                {
                    case "A":
                        Console.WriteLine(x + y);
                        break;
                    case "D":
                        Console.WriteLine(x / y);
                        break;
                    case "M":
                        Console.WriteLine(x * y);
                        break;
                    case "S":
                        Console.WriteLine(x - y);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else Console.WriteLine("error");
        }
    }
}
