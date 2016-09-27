using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    /* **************************************************************
     *          New Queue class implemented using two Stacks.
     * *************************************************************/

    class QueueWithStacks<T>
    {
        private Stack<T> queueStack;
        private Stack<T> tempStack;

        public QueueWithStacks()
        {
            queueStack = new Stack<T>();
            tempStack = new Stack<T>();
        }

        public bool IsEmpty()
        {
            return (queueStack.Count == 0 && tempStack.Count == 0);
        }

        public void Enqueue(T element)
        {
            if (this.IsEmpty()) queueStack.Push(element);
            else tempStack.Push(element);
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("The queue is empty.\n");
                Environment.Exit(-1);
            }

            T dequeued = queueStack.Pop();
            if (queueStack.Count == 0) PourTempToQueue();
            return dequeued;
        }

        public T Peek()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("The queue is empty.\n");
                Environment.Exit(-1);
            }
            return queueStack.Peek();
        }

        public void PourTempToQueue()
        {
            if (tempStack.Count == 0) return ;
            while (tempStack.Count > 0) { queueStack.Push(tempStack.Pop()); }
        }
    }

    /* **************************************************************
     *                    Main Testing Class!
     * *************************************************************/

    class Chapter3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Queue's engine is made of Stacks!");
            var newq = new QueueWithStacks<int>();

            Console.WriteLine("\nEnqueueing and Dequeueing at once!");
            for (int i = 1; i <= 3; i++) { newq.Enqueue(i); }
            while (!newq.IsEmpty()) { Console.WriteLine(newq.Dequeue()); }

            for (int i = 4; i <= 7; i++) { newq.Enqueue(i); }
            Console.WriteLine("\nDequeue one...");
            Console.WriteLine(newq.Dequeue());

            Console.WriteLine("\nEnqueue some more...");
            for (int i = 8; i <= 10; i++) { newq.Enqueue(i); }

            Console.WriteLine("\nDequeue all remaining!");
            while (!newq.IsEmpty()) { Console.WriteLine(newq.Dequeue()); }
        }
    }
}
