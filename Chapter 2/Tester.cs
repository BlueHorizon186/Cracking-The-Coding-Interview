using System;

namespace CrackingTheCodingInterview
{
    class Chapter2
    {
        static void Main(string[] args)
        {
            var myList = new MyLinkedList();

            myList.AddElement(5);
            myList.AddElement(10);
            myList.AddElement(17);
            myList.AddElement(23);
            myList.AddElement(19);
            myList.AddElement("lolpol");
            myList.AddElement(23.45);

            myList.PrintList();
            Console.WriteLine(myList.Size);
        }
    }
}
