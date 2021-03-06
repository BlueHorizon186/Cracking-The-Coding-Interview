using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public partial class MyLinkedList
    {
        /* **************************************************************
         *          Remove duplicate elements from the list,
         *          using a HashSet.
         * *************************************************************/

        public void RemoveDuplicatesWithHash()
        {
            var foundElements = new HashSet<int>();
            Node current = root;
            Node previous = null;

            while(current != null)
            {
                if (foundElements.Contains(current.Data))
                {
                    previous.Next = current.Next;
                }

                else
                {
                    foundElements.Add(current.Data);
                    previous = current;
                }
                current = current.Next;
            }
        }

        /* **************************************************************
         *          Remove duplicate elements from the list,
         *          using two pointers to find them.
         * *************************************************************/

        public void RemoveDuplicatesWithPointers()
        {
            Node current = root;
            Node runner = null;

            while (current != null)
            {
                runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                        runner.Next = runner.Next.Next;
                    else
                        runner = runner.Next;
                }
                current = current.Next;
            }
        }
    }
}
