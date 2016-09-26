using System;

namespace CrackingTheCodingInterview
{
    class NewStack<T>
    {
        private NewStackNode<T> top;
        private NewStackNode<T> bottom;

        public int Size { get; set; }
        public int MaxCapacity { get; set; }

        public NewStack(int capacity)
        {
            top = null;
            bottom = null;
            Size = 0;
            MaxCapacity = capacity;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public bool IsFull()
        {
            return Size == MaxCapacity;
        }

        public void Push(T element)
        {
            // Missing: Check if the stack still has enough space.
            var newNode = new NewStackNode<T>(element);
            if (this.IsEmpty())
            {
                bottom = newNode;
                top = newNode;
            }
            else
            {
                newNode.Below = top;
                top.Above = newNode;
                top = newNode;
            }
            Size++;
        }

        public T Pop()
        {
            // Missing: Check if Stack is Empty before popping.
            NewStackNode<T> popped = top;
            top = top.Below;
            if (top != null) top.Above = null;
            Size--;
            return popped.Data;
        }

        public T Peek()
        {
            // Missing: Check if Stack is Empty before peeking.
            return top.Data;
        }

        public T RemoveBottom()
        {
            // Missing: Check if Stack is Empty before removing.
            NewStackNode<T> removed = bottom;
            bottom = bottom.Above;
            if (bottom != null) bottom.Below = null;
            Size--;
            return removed.Data;
        }

        public void PrintStack()
        {
            var p = top;
            Console.Write("{ ");

            while (p != null)
            {
                Console.Write("{0} ", p.Data);
                p = p.Below;
            }
            Console.Write("}\n");
        }
    }
}
