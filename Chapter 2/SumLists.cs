using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    class Chapter2
    {
        /* **************************************************************
         *              Add two numbers as Linked Lists.
         * *************************************************************/

         // Simple recursive function to calculate the power of a number.
         private static int Power(int x, int y)
         {
             if (y <= 0) return 1;
             if (y == 1) return x;
             return x * Power(x, y - 1);
         }

         // Convert a number given as a Linked List to an int.
         private static int ListToNumber(LinkedList<int> lst)
         {
             var number = 0;
             var exponent = 0;

             foreach (var item in lst)
             {
                 number += item * Power(10, exponent);
                 exponent++;
             }
             return number;
         }

         // Convert a number to a Linked List.
         private static LinkedList<int> NumberToList(int num)
         {
             var numList = new LinkedList<int>();
             while (num > 0)
             {
                 numList.AddLast(num % 10);
                 num /= 10;
             }
             return numList;
         }

         public static LinkedList<int> AddLists(LinkedList<int> lst1,
                                                LinkedList<int> lst2)
        {
            // Missing: Validate that the lists are not null.
            int num1 = ListToNumber(lst1);
            int num2 = ListToNumber(lst2);
            LinkedList<int> result = NumberToList(num1 + num2);
            return result;
        }

        /* **************************************************************
         *     Add two numbers in Linked Lists without converting
         *     them to integers and back to lists.
         * *************************************************************/

         private static void AddRemaining(LinkedList<int> result,
                                          LinkedListNode<int> remaining,
                                          ref int carry)
        {
            while (remaining != null)
            {
                var temp = remaining.Value + carry;
                result.AddLast(temp % 10);
                carry = temp / 10;
                remaining = remaining.Next;
            }
        }

         public static LinkedList<int> AddListsWithoutConverting(LinkedList<int> n1,
                                                                 LinkedList<int> n2)
        {
            // Missing: Validate that both lists are not null.
            var result = new LinkedList<int>();
            var carry = 0;

            LinkedListNode<int> p = n1.First;
            LinkedListNode<int> q = n2.First;

            while (p != null && q != null)
            {
                var temp = p.Value + q.Value + carry;
                result.AddLast(temp % 10);
                carry = temp / 10;

                p = p.Next;
                q = q.Next;
            }

            if (p == null) AddRemaining(result, q, ref carry);
            else if (q == null) AddRemaining(result, p, ref carry);
            
            if (carry > 0) result.AddLast(carry);
            return result;
        }

        /* **************************************************************
         *                    Testing Main Method!!!
         * *************************************************************/

        static void PrintList(LinkedList<int> lst)
        {
            Console.Write("{ ");
            foreach (var item in lst)
            {
                Console.Write("{0} ", item.ToString());
            }
            Console.Write("}\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum Lists!");

            var n1 = new LinkedList<int>();
            var n2 = new LinkedList<int>();

            n1.AddFirst(6);
            n1.AddFirst(1);
            n1.AddFirst(7);

            n2.AddFirst(2);
            n2.AddFirst(9);
            n2.AddFirst(5);

            var r1 = AddListsWithoutConverting(n1, n2);
            var r2 = AddLists(n1, n2);

            Console.WriteLine("\nNumbers to be Added:");
            PrintList(n1);
            PrintList(n2);

            Console.Write("Result Without Converting: ");
            PrintList(r1);
            Console.Write("Result Converting: ");
            PrintList(r2);

            n1.Clear();
            n2.Clear();

            n1.AddFirst(1);
            n1.AddFirst(9);
            n1.AddFirst(1);
            n1.AddFirst(2);

            n2.AddFirst(3);
            n2.AddFirst(8);
            n2.AddFirst(8);

            var r3 = AddListsWithoutConverting(n1, n2);
            var r4 = AddLists(n1, n2);

            Console.WriteLine("\nNumbers to be Added:");
            PrintList(n1);
            PrintList(n2);

            Console.Write("Result Without Converting: ");
            PrintList(r3);
            Console.Write("Result Converting: ");
            PrintList(r4);
        }
    }
}
