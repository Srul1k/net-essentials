namespace StringParserLibrary
{
    public class StringParser : IStringParser
    {
        public event IStringParser.StringEventHandler OnStringContainsBLetter;
        public event IStringParser.StringEventHandler OnStringContainsZLetter;

        public void Parse(string str)
        {
            var buffer = str.ToLower().ToCharArray();
            int bCount = 0;
            int zCount = 0;

            foreach (var letter in buffer)
            {
                if (letter.CompareTo('b') == 0)
                {
                    bCount++;
                    OnStringContainsBLetter(this, new StringEventArguments('B', bCount));
                }
                else if (letter.CompareTo('z') == 0)
                {
                    zCount++;
                    OnStringContainsZLetter(this, new StringEventArguments('Z', zCount));
                }
            }
        }
    }
}
