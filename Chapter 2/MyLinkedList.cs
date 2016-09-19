using System;

namespace CrackingTheCodingInterview
{
    public class MyLinkedList
    {
        private Node root;
        public int Size { get; set; }

        // Basic Linked List implementation.
        public MyLinkedList()
        {
            root = null;
            Size = 0;
        }

        public void PrintList()
        {
            if (Size < 1) Console.WriteLine("The List is empty.");
            else Console.WriteLine("To be implemented...");
        }
    }
}
