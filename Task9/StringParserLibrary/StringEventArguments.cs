namespace StringParserLibrary
{
    public class StringEventArguments
    {
        public char Letter { get; }
        public int Count { get; }

        public StringEventArguments(char letter, int count)
        {
            Letter = letter;
            Count = count;
        }
    }
}
