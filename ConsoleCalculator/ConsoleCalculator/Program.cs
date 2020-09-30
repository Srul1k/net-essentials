using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            if (args.Length == 3 &&
                TryParseWithSpecifiedRange(args[0], out double x) &&
                TryParseWithSpecifiedRange(args[1], out double y))
            {
                switch (args[2])
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
            var buffer = s.Split('.');
            if (buffer.Length > 1)
                if (buffer[1].Length > 5)
                {
                    x = double.NaN;
                    return false;
                }
            
            return double.TryParse(s, out x) && x >= -10000 && x <= 10000;
        }
    }
}
