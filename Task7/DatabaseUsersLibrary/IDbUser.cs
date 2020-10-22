namespace DatabaseUsersLibrary
{
    public interface IDbUser<T> where T : IDatabase
    {
        void UseDatabase(T db);
    }
}
