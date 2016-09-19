using System;

namespace CrackingTheCodingInterview
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        // Basic Node implementation.
        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
