using System;

namespace DatabaseUsersLibrary
{
    public class AdminDbUser : IDbUser<IReadUpdateWriteDatabase>
    {
        public void UseDatabase(IReadUpdateWriteDatabase db)
        {
            db.WriteData("Admin write data");
            db.ReadData();
            db.UpdateData(d => d += " Admin update data");
        }
    }
}
