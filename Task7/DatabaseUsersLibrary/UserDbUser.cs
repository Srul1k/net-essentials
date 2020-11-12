using System;

namespace DatabaseUsersLibrary
{
    public class UserDbUser : IDbUser<IReadDatabase>
    {
        public string UseDatabase(IReadDatabase db)
        {
            return db.ReadData() + Environment.NewLine;
        }
    }
}
