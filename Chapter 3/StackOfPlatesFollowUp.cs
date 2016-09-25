using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    /* **************************************************************
     *                    Main Testing Class!
     * *************************************************************/

    class Chapter3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set of Stacks Test!\n");
            var nst = new NewStack<int>(5);
            for (int i = 1; i <= 5; i++) nst.Push(i);
            nst.PrintStack();

            nst.Pop();
            nst.Pop();
            nst.Push(7);
            nst.PrintStack();
            Console.WriteLine("\n{0}", nst.Peek());
        }
    }
}
