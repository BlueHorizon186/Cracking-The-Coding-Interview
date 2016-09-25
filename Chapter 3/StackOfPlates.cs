using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    /* **************************************************************
     *            New Stack class with a limited capacity.
     *            Extends the default Stack<T> class.
     * *************************************************************/

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

        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void PrintStack()
        {
            Console.Write("{ ");
            foreach (var item in this)
            {
                Console.Write("{0} ", item.ToString());
            }
            Console.Write("}\n");
        }
    }

    /* **************************************************************
     *    StackSet class. Manages stacks automatically according
     *    to the stacks' individual capacity.
     * *************************************************************/

    class StackSet<T>
    {
        private List<StackOfPlates<T>> stacks;
        private int stackCapacity;
        private int totalStacks;

        public StackSet(int _stackCapacity)
        {
            stacks = new List<StackOfPlates<T>>();
            stackCapacity = _stackCapacity;
            totalStacks = 0;
            CreateNewStack();
        }

        private void CreateNewStack()
        {
            stacks.Add(new StackOfPlates<T>(stackCapacity));
            totalStacks++;
        }

        private void RemoveLastStack()
        {
            stacks.RemoveAt(--totalStacks);
        }

        public void Push(T element)
        {
            if (!stacks[totalStacks-1].IsFull())
            {
                stacks[totalStacks-1].Push(element);
            }
            else
            {
                CreateNewStack();
                stacks[totalStacks-1].Push(element);
            }
        }

        public T Pop()
        {
            var popped = stacks[totalStacks-1].Pop();
            if (stacks[totalStacks-1].IsEmpty()) { RemoveLastStack(); }
            return popped;
        }

        public T Peek()
        {
            return stacks[totalStacks-1].Peek();
        }

        public void PrintAllStacks()
        {
            for (int i = 0; i < totalStacks; i++)
            {
                Console.WriteLine("Stack {0}:", i + 1);
                stacks[i].PrintStack();
            }
        }
    }

    /* **************************************************************
     *                    Main Testing Class!
     * *************************************************************/

    class Chapter3
    {
        private static void initStackSet(StackSet<int> ss)
        {
            for (int i = 1; i <= 15; i++)
            {
                ss.Push(i);
            }
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("Trying out some inheritance.");
            var st = new StackOfPlates<int>(5);
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.PrintStack();

            Console.WriteLine(st.IsFull());
            st.Push(2);
            st.Push(3);
            Console.WriteLine(st.IsFull());*/

            Console.WriteLine("Set of Stacks Test!\n");
            var myPlates = new StackSet<int>(5);
            initStackSet(myPlates);
            myPlates.PrintAllStacks();

            for (int i = 0; i < 7; i++) { myPlates.Pop(); }
            Console.Write("\n");
            myPlates.PrintAllStacks();
            Console.WriteLine("\n{0}", myPlates.Peek());
        }
    }
}
