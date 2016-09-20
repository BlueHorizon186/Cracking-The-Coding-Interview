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
            return ;
        }
    }
}
