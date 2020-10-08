using System;
using System.Collections.Generic;
using System.Linq;

namespace DfsSearchLibrary
{
    public class DfsSearch
    {
        private Dictionary<int, Node> indexingByNumber;
        private Dictionary<string, Node> indexingByValue;
        private int ind;

        public DfsSearch(Node tree)
        {
            indexingByNumber = new Dictionary<int, Node>();
            indexingByValue = new Dictionary<string, Node>();
            ind = -1;
            DFS(tree);
        }

        private void DFS(Node n)
        {
            ind++;
            indexingByNumber.Add(ind, n);
            indexingByValue.Add(n.Val, n);

            if (n.Left != null) DFS(n.Left);
            if (n.Right != null) DFS(n.Right);
        }

        public Node this[int index]
        {
            get => indexingByNumber[index];
        }

        public Node this[string val]
        {
            get => indexingByValue[val];
        }
    }
}
