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
            int startIndex = 0;
            if (tree != null) IndexNodes(tree, ref startIndex);
        }

        private void IndexNodes(Node n, ref int ind)
        {
            indexingByNumber.Add(ind, n);
            indexingByValue.Add(n.Val, n);
            ind++;

            if (n.Left != null) IndexNodes(n.Left, ref ind);
            if (n.Right != null) IndexNodes(n.Right, ref ind);
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
