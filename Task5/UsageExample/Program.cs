using System;
using DfsSearchLibrary;

namespace UsageExample
{
    class Program
    {
        static void Main()
        {
            var i = new Node(null, null, "I");
            var h = new Node(null, null, "H");
            var g = new Node(null, null, "G");
            var f = new Node(h, i, "F");
            var e = new Node(g, null, "E");
            var d = new Node(null, null, "D");
            var b = new Node(d, e, "B");
            var c = new Node(null, f, "C");
            var a = new Node(b, c, "A");

            DfsSearch dfs = new DfsSearch(a);

            Console.WriteLine(dfs[7].Val); // H
            var n = dfs["E"];
            dfs = new DfsSearch(null);
        }
    }
}
