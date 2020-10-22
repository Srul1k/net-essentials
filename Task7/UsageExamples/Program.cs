using System;
using DatabaseUsersLibrary;

namespace UsageExamples
{
    class Program
    {
        static void Main()
        {
            Database db = new Database();

            UserDbUser user = new UserDbUser();
            ManagerDbUser manager = new ManagerDbUser();
            AdminDbUser admin = new AdminDbUser();

            admin.UseDatabase(db);
            manager.UseDatabase(db);
            user.UseDatabase(db);
        }
    }
}
