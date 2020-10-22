using System;

namespace DatabaseUsersLibrary
{
    public interface IReadUpdateDatabase : IReadDatabase
    {
        void UpdateData(Func<string, string> update);
    }
}
