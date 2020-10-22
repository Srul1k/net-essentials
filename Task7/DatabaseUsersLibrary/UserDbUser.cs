namespace DatabaseUsersLibrary
{
    public class UserDbUser : IDbUser<IReadDatabase>
    {
        public void UseDatabase(IReadDatabase db)
        {
            db.ReadData();
        }
    }
}
