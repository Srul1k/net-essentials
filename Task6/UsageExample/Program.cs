using System;
using CacheLibrary;

namespace UsageExample
{
    class Program
    {
        static void Main()
        {
            var cashe = new Cashe<double, string>();

            cashe.AddOrUpdate(0.1, "seagull", new DateTime(0));
            cashe.AddOrUpdate(20.2, "tea", new DateTime(2999, 1, 1));
            cashe.AddOrUpdate(3, "coffe", new DateTime(2999, 1, 1));

            var a = cashe.Get(0.1);  // null
            var b = cashe.Get(0);    // null
            var c = cashe.Get(20.2); // tea

            var r1 = cashe.Remove(0.1);  // true
            var r2 = cashe.Remove(10);   // false
        }
    }
}
