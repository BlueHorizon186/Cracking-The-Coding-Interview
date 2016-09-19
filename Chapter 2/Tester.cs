using System;

namespace CrackingTheCodingInterview
{
    class Chapter2
    {
        static void Main(string[] args)
        {
            var myList = new MyLinkedList();
            var myNode = new Node(5);

            myList.PrintList();
            Console.WriteLine(myNode.ToString());
        }
    }
}
