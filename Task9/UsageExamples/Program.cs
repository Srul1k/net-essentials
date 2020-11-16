using System;
using StringParserLibrary;

namespace UsageExamples
{
    class Program
    {
        static void Main()
        {
            IStringParser sp = new StringParser();

            sp.OnStringContainsBLetter += Sp_OnStringContainsBLetter;
            sp.OnStringContainsZLetter += Sp_OnStringContainsZLetter;

            sp.Parse("asdsadBbzazzszbzdzZdbsabdbbbbb");
        }

        private static void Sp_OnStringContainsZLetter(object sender, StringEventArguments e)
        {
            Console.WriteLine($"letter Z occurs {e.Count} times");
        }
        private static void Sp_OnStringContainsBLetter(object sender, StringEventArguments e)
        {
            Console.WriteLine($"letter B occurs {e.Count} times");
        }
    }
}
