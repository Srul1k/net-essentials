using System;

namespace DfsSearchLibrary
{
    public class Node
    {
        public Node Left { get; }
        public Node Right { get; }
        public string Val { get; }

        public Node(Node left, Node right, string val)
        {
            Left = left;
            Right = right;
            Val = val;
        }
    }
}
