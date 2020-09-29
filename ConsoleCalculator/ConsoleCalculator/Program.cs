using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            var buffer = Console.ReadLine().Split(' ');

            if (buffer.Length == 3 &&
                TryParseWithSpecifiedRange(buffer[0], out double x) &&
                TryParseWithSpecifiedRange(buffer[1], out double y))
            {
                switch (buffer[2])
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

        private static bool TryParseWithSpecifiedRange(string s, out double x)
        {
            bool result;

            var buffer = s.Split('.');
            if (buffer.Length > 1)
                if (buffer[1].Length > 5)
                {
                    x = double.NaN;
                    return false;
                }
            
            result = double.TryParse(s, out x);
            return result && x >= -10000 & x <= 10000;
        }
    }
}
