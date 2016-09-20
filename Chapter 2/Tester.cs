using System;

namespace CrackingTheCodingInterview
{
    class Chapter2
    {
        const int ELEMS = 10;

        static void FillList(MyLinkedList lst)
        {
            Random rand = new Random();
            for (int i = 0; i < ELEMS; i++)
            {
                lst.AddElement(rand.Next(ELEMS));
            }
        }
        
        static void Main(string[] args)
        {
            // Populate our Linked List.
            var myList = new MyLinkedList();
            FillList(myList);

            // Print our list.
            Console.WriteLine("First List:");
            myList.PrintList();

            // Let's remove the duplicated elements using our Hash method.
            myList.RemoveDuplicatesWithHash();
            Console.WriteLine("List Without Duplicates:");
            myList.PrintList();
        }
    }
}
