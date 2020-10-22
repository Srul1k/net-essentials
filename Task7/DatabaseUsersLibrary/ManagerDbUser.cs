namespace DatabaseUsersLibrary
{
    public class ManagerDbUser : IDbUser<IReadUpdateDatabase>
    {
        public void UseDatabase(IReadUpdateDatabase db)
        {
            db.ReadData();
            db.UpdateData(d => d += " Manager update data");
        }
    }
}
