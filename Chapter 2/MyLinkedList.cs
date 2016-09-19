using System;

namespace CrackingTheCodingInterview
{
    // Basic Linked List implementation.
    public class MyLinkedList
    {
        // The 'root' field stores the head of the list.
        private Node root;

        // The Size property stores the number of elements the list
        // currently has.
        public int Size { get; set; }

        // Constructor.
        public MyLinkedList()
        {
            root = null;
            Size = 0;
        }

        // Add a new element to the tail of the list.
        public void AddElement(object data)
        {
            if (root == null)
            {
                root = new Node(data);
                Size++;
                return ;
            }

            var newElement = new Node(data);
            var current = root;

            while (current.Next != null) current = current.Next;
            current.Next = newElement;
            Size++;
        }

        // Check if list is empty.
        public bool IsEmpty()
        {
            return Size < 1;
        }

        // Print the elements of the list.
        public void PrintList()
        {
            if (IsEmpty()) Console.WriteLine("The List is empty.");
            
            var current = root;
            Console.Write("{ ");

            while (current != null)
            {
                Console.Write("{0} ", current.ToString());
                current = current.Next;
            }
            Console.Write("}\n");
        }
    }
}
