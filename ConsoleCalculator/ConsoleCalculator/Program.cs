using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            try
            {
                string result = Calculator.Solve(args[0], args[1], args[2]);
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
