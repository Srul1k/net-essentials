namespace ConsoleCalculator
{
    public static class CalculatorHelper
    {
        public static bool DoubleTryParseWithSpecificRange(string s, out double x)
        {
            var buffer = s.Split('.');
            if (buffer.Length > 1)
                if (buffer[1].Length > 5)
                {
                    double.TryParse(s, out x);
                    return false;
                }

            return double.TryParse(s, out x) && x >= -10000 && x <= 10000;
        }
    }
}
