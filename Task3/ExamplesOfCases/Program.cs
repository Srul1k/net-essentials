using System;
using MoneyLibrary;

namespace ExamplesOfCases
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Money(100, Currency.USD);
            var m2 = new Money(200, Currency.EUR);
            var m3 = new Money(300, Currency.BYN);

            var m4 = m1 + m2; // 350 USD
            var m5 = m2 + m1; // 280 EUR
            Console.WriteLine(m4 == m5);

            var m6 = m2 - m3; // 80 EUR

            m1++; // 100 + 10 % = 110 USD
            m2++; // 200 + 20% = 240 EUR
            m3++; // 300 + 30% = 390 BYN
            string s1 = (string)m1;    // "110,00000_USD"
            string s2 = (string)m2;    // "240,00000_EUR"
            string s3 = (string)m3;    // "390,00000_BYN"
            int x1 = m1;		// 220
            int x2 = m2;		// 600
            int x3 = m3;		// 390
        }
    }
}
