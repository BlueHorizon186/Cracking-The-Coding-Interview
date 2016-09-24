using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    class StackOfPlates<T> : Stack<T>
    {
        public int MaxCapacity { get; set; }

        public StackOfPlates(int capacity)
        {
            MaxCapacity = capacity;
        }

        public bool IsFull()
        {
            return this.Count == this.MaxCapacity;
        }

        public void PrintStack()
        {
            foreach (var item in this) { Console.WriteLine(item.ToString()); }
        }
    }

    class StackSet<T>
    {

    }

    class Chapter3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trying out some inheritance.");
            var st = new StackOfPlates<int>(5);
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.PrintStack();

            Console.WriteLine(st.IsFull());
            st.Push(2);
            st.Push(3);
            Console.WriteLine(st.IsFull());
        }
    }
}
