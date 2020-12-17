using System;

namespace ExceptionsLibrary
{
    public class PersonNotCreatedException : Exception
    {
        public PersonNotCreatedException(string message) : base(message) { }
    }
}
