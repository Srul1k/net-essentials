using NUnit.Framework;

namespace ConsoleCalculator.Tests
{
    [TestFixture]
    [SetCulture("en-US")]
    public class Calculator_SolveShould
    {
        [TestCase(30.02, 5.9, "M", "177.118")]
        [TestCase(10000.00000, 30.1, "S", "9969.9")]
        [TestCase(100.00, 20.1, "A", "120.1")]
        [TestCase(100, 50, "D", "2")]
        public void Solve_ReturnCorrectResult(double a, double b, string operation, string expectedResult)
        {
            var actualResult = Calculator.Solve(a.ToString(), b.ToString(), operation);

            Assert.AreEqual(expectedResult, actualResult);
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
