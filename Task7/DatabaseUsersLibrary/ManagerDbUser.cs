using System;

namespace DatabaseUsersLibrary
{
    public class ManagerDbUser : IDbUser<IReadUpdateDatabase>
    {
        public string UseDatabase(IReadUpdateDatabase db)
        {
            string result = String.Empty;

            db.UpdateData(d => d += " Manager update data");
            result += db.ReadData() + Environment.NewLine;

            return result;
        }
    }
}
