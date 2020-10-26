namespace StringParserLibrary
{
    public interface IStringParser
    {
        delegate void StringEventHandler(object sender, StringEventArguments e);
        event StringEventHandler OnStringContainsBLetter;
        event StringEventHandler OnStringContainsZLetter;

        void Parse(string str);
    }
}
