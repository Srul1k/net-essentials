using System;

namespace DatabaseUsersLibrary
{
    public class AdminDbUser : IDbUser<IReadUpdateWriteDatabase>
    {
        public string UseDatabase(IReadUpdateWriteDatabase db)
        {
            string result = String.Empty;

            db.WriteData("Admin write data");
            result += db.ReadData() + Environment.NewLine;
            db.UpdateData(d => d += " Admin update data");
            result += db.ReadData() + Environment.NewLine;

            return result;
        }
    }
}
