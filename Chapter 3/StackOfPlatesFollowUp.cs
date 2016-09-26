using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    /* **************************************************************
     *    StackSet class. Manages stacks automatically according
     *    to the stacks' individual capacity.
     * *************************************************************/

    class StackSet<T>
    {
        private List<NewStack<T>> stacks;
        private int stackCapacity;
        private int totalStacks;

        public StackSet(int _stackCapacity)
        {
            stacks = new List<NewStack<T>>();
            stackCapacity = _stackCapacity;
            totalStacks = 0;
            CreateNewStack();
        }

        private void CreateNewStack()
        {
            stacks.Add(new NewStack<T>(stackCapacity));
            totalStacks++;
        }

        private void RemoveLastStack()
        {
            stacks.RemoveAt(--totalStacks);
        }

        public void Push(T element)
        {
            var st = stacks[totalStacks - 1];
            if (!st.IsFull())
            {
                st.Push(element);
            }
            else
            {
                CreateNewStack();
                st = stacks[totalStacks - 1];
                st.Push(element);
            }
        }

        public T Pop()
        {
            var st = stacks[totalStacks - 1];
            var popped = st.Pop();
            if (st.IsEmpty()) { RemoveLastStack(); }
            return popped;
        }

        public T Peek()
        {
            var st = stacks[totalStacks - 1];
            return st.Peek();
        }

        public T PopFrom(int stackId)
        {
            var st = stacks[stackId];
            var popped = st.Pop();
            AdjustStacks(stackId);
            return popped;
        }

        private void AdjustStacks(int poppedFromStackId)
        {
            int nextStackId = poppedFromStackId + 1;
            var currentStack = stacks[poppedFromStackId];

            if (nextStackId < totalStacks)
            {
                var nextStack = stacks[nextStackId];
                currentStack.Push(nextStack.RemoveBottom());
                AdjustStacks(nextStackId);
            }

            // This can only happen if there is no following stack,
            // as the only way to empty a stack in this process, is
            // if the last one only had one element.
            if (currentStack.IsEmpty()) { RemoveLastStack(); }
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
        const int ELEMENTS = 15;

        static void InitStackSet(StackSet<int> ss)
        {
            for (int i = 1; i <= ELEMENTS; i++)
            {
                ss.Push(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Set of Stacks Test!\n");
            var stOfPlates = new StackSet<int>(5);
            InitStackSet(stOfPlates);
            stOfPlates.PrintAllStacks();

            stOfPlates.Pop();
            stOfPlates.Pop();
            Console.Write("\n");
            stOfPlates.PrintAllStacks();

            stOfPlates.PopFrom(0);
            Console.Write("\n");
            stOfPlates.PrintAllStacks();

            stOfPlates.PopFrom(0);
            Console.Write("\n");
            stOfPlates.PrintAllStacks();

            stOfPlates.PopFrom(1);
            Console.Write("\n");
            stOfPlates.PrintAllStacks();
        }
    }
}
