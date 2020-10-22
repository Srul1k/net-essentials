namespace DatabaseUsersLibrary
{
    public interface IReadUpdateWriteDatabase : IReadUpdateDatabase
    {
        void WriteData(string data);
    }
}
