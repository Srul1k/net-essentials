namespace ConsoleCalculator
{
    public static class Calculator
    {
        public static string Solve(string a, string b, string operation)
        {
            if (CalculatorHelper.DoubleTryParseWithSpecificRange(a, out double x) &&
                CalculatorHelper.DoubleTryParseWithSpecificRange(b, out double y))
            {
                switch (operation)
                {
                    case "A":
                        return (x + y).ToString();
                    case "D":
                        return (x / y).ToString();
                    case "M":
                        return (x * y).ToString();
                    case "S":
                        return (x - y).ToString();
                    default:
                        return "error";
                }
            }
            else return ("error");
        }
    }
}
