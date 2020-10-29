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

            Console.WriteLine(admin.UseDatabase(db));
            Console.WriteLine(manager.UseDatabase(db));
            Console.WriteLine(user.UseDatabase(db));
        }
    }
}
