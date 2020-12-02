using System;

namespace ExceptionsLibrary
{
    public class WrongGenderException : ArgumentException
    {
        public string Value { get; }
        public WrongGenderException() { }
        public WrongGenderException(string message) : base(message) { }
        public WrongGenderException(string message, string value) : this(message)
        {
            Value = value;
        }
    }
}
