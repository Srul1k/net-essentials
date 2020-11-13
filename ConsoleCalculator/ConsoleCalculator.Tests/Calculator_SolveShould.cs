using NUnit.Framework;
using System;

namespace ConsoleCalculator.Tests
{
    [TestFixture]
    [SetCulture("en-US")]
    public class Calculator_SolveShould
    {
        private double InitializationOfOperationResult(double a, double b, string operation)
        {
            double x = Double.NaN;

            switch (operation)
            {
                case "A":
                    x = a + b;
                    break;
                case "D":
                    x = a / b;
                    break;
                case "M":
                    x = a * b;
                    break;
                case "S":
                    x = a - b;
                    break;
            }

            return x;
        }

        [TestCase(30.02, 5.9, "M")]
        [TestCase(10000.00000, 30.1, "S")]
        [TestCase(100.00, 20.1, "A")]
        [TestCase(100, 50, "D")]
        public void Solve_ReturnCorrectResult(double a, double b, string operation)
        {
            double x = InitializationOfOperationResult(a, b, operation);

            var actualResult = Calculator.Solve(a.ToString(), b.ToString(), operation);
            var exceptedResult = x.ToString();

            Assert.AreEqual(exceptedResult, actualResult);
        }

        [TestCase("O", "1", "A")]
        [TestCase("24", "86.123456", "D")]
        [TestCase("-10000.00001", "0.00001", "S")]
        [TestCase("2", "3", "C")]
        public void Solve_ReturnStringError(string a, string b, string operation)
        {
            var actualResult = Calculator.Solve(a, b, operation);

            Assert.AreEqual("error", actualResult);
        }
    }
}
