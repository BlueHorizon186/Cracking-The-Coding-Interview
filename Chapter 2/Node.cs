using System;

namespace CrackingTheCodingInterview
{
    class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        // Basic Node implementation.
        public Node(object data)
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
