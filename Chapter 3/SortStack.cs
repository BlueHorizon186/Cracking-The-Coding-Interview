using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    class Chapter3
    {
        private static Stack<int> SortStack(Stack<int> s)
        {
            var r = new Stack<int>();
            while (s.Count > 0)
            {
                var temp = s.Pop();
                while (r.Count > 0 && r.Peek() > temp) { s.Push(r.Pop()); }
                r.Push(temp);
            }
            return r;
        }

        private static void PrintStack(Stack<int> st)
        {
            Console.Write("{ ");
            foreach (var item in st)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("}\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sort Stacks using a temporary one!");
            var myStack = new Stack<int>();

            myStack.Push(5);
            myStack.Push(4);
            myStack.Push(7);
            myStack.Push(2);
            myStack.Push(6);

            Console.WriteLine("\nElements in Stack:");
            PrintStack(myStack);

            myStack = SortStack(myStack);
            Console.WriteLine("\nSorted Stack:");
            PrintStack(myStack);
        }
    }
}
