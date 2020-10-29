namespace StringParserLibrary
{
    public interface IStringParser
    {
        event StringEventHandler OnStringContainsBLetter;
        event StringEventHandler OnStringContainsZLetter;

        void Parse(string str);
    }
}
