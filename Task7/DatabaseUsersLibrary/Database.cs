using System;

namespace DatabaseUsersLibrary
{
    public class Database : IDatabase, IReadUpdateWriteDatabase, IReadUpdateDatabase, IReadDatabase
    {
        public string Shema { get; }

        private string _data;

        public Database()
        {
            _data = String.Empty;
        }

        public string ReadData()
        {
            return _data;
        }

        public void WriteData(string data)
        {
            _data = data;
        }

        public void UpdateData(Func<string, string> update)
        {
            if (update != null)
            {
                _data = update(_data);
            }
        }
    }
}
