using NUnit.Framework;
using System;

namespace ConsoleCalculator.Tests
{
    [TestFixture]
    [SetCulture("en-US")]
    public class CalculatorHelper_DoubleTryParseWithSpecificRangeShould
    {
        [TestCase("42")]
        [TestCase("100.12345")]
        [TestCase("20.2")]
        [TestCase("-10000.00000")]
        [TestCase("-0.69")]
        public void DoubleTryParseWithSpecificRange_ReturnCorrectResult(string s)
        {
            double actualResult;
            bool methodResult = CalculatorHelper.DoubleTryParseWithSpecificRange(s, out actualResult);

            double exceptedResult = Double.Parse(s);

            Assert.AreEqual(exceptedResult, actualResult);
            Assert.IsTrue(methodResult);
        }

        [TestCase("100.123456")]
        [TestCase("-10000.00001")]
        [TestCase("-1000,2")]
        [TestCase("peep")]
        [TestCase("--3")]
        public void DoubleTryParseWithSpecificRange_ReturnFalse(string s)
        {
            double x;
            bool result = CalculatorHelper.DoubleTryParseWithSpecificRange(s, out x);

            Assert.IsFalse(result);
        }
    }
}