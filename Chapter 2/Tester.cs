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
            Console.WriteLine("\nList Without Duplicates:");
            myList.PrintList();

            // We add some more elements to have more duplicates.
            FillList(myList);
            Console.WriteLine("\nNew List:");
            myList.PrintList();

            // And now, we try our remove with pointers method.
            myList.RemoveDuplicatesWithPointers();
            Console.WriteLine("\nList Without Duplicates:");
            myList.PrintList();
        }
    }
}
