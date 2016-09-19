using System;
using System.Linq;

namespace CrackingTheCodingInterview
{
    class Chapter1
    {
        /* **************************************************************
         *             1) String has only Unique Characters
         * *************************************************************/
        public static bool IsUniqueWithSort(String str)
        {
            if (str.Length > 26) return false;

            char[] strArr = str.ToArray();
            Array.Sort(strArr);

            for (int i = 1; i < strArr.Length; i++)
            {
                if (strArr[i] == strArr[i - 1]) return false;
                else continue;
            }
            return true;
        }

        // Only works with lowercase strings.
        public static bool IsUniqueWithBitwise(String str)
        {
            if (str.Length > 26) return false;

            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var charValue = str[i] - 97;
                if ((checker & (1 << charValue)) > 0) return false;
                checker |= (1 << charValue);
            }
            return true;
        }

        /* **************************************************************
         *                    Testing Main Method!!!
         * *************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // IsUnique Tests
            Console.WriteLine("aab is unique with sort? {0}",
                            IsUniqueWithSort("aab"));
            Console.WriteLine("aab is unique with bitwise? {0}",
                            IsUniqueWithBitwise("aab"));
            Console.WriteLine("abc is unique with sort? {0}",
                            IsUniqueWithSort("abc"));
            Console.WriteLine("abc is unique with bitwise? {0}",
                            IsUniqueWithBitwise("abc"));
        }
    }
}
