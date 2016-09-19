using System;

namespace CrackingTheCodingInterview
{
    class Chapter1
    {
        /* **************************************************************
         *         Check if string is permutation of a 
         *         palindrome using a frequency table.
         * *************************************************************/

        public static void initTable(ref int[] table, int size)
        {
            if (table == null) table = new int[size];
            for (int i = 0; i < size; i++) table[i] = 0;
        }

        public static bool IsPalindromePermutationWithHash(string str)
        {
            // Missing: Trim whitespace the given string might contain.
            var tableSize = 'z' - 'a' + 1;
            var lettersFreqTable = new int[tableSize];
            initTable(ref lettersFreqTable, tableSize);

            foreach (char c in str.ToLower())
            {
                int cNumValue = (int) (c - 'a');
                if (cNumValue != -1) lettersFreqTable[cNumValue]++;
            }

            // Possible optimization: Check for odd during the first run
            // through the string.
            int foundOdd = 0;
            for (int i = 0; i < tableSize; i++)
            {
                if (lettersFreqTable[i] % 2 == 1)
                {
                    if (foundOdd >= 1) return false;
                    else foundOdd++;
                }
            }
            return true;
        }

        /* **************************************************************
         *         Check if string is permutation of a 
         *         palindrome using a bit vector.
         * *************************************************************/

         public static void toggleBit(ref int vector, int index)
         {
             if (index < 0) return ;

             int mask = 1 << index;
             if ((vector & mask) == 0) vector |= mask;
             else vector &= ~mask;
         }

         public static bool hasOnlyOneBitSet(int bitVector)
         {
             return ((bitVector & (bitVector - 1)) == 0);
         }

         public static bool IsPalindromePermutationWithBitVector(string str)
         {
             // Missing: Trim whitespace the given string might contain.
             int bitVector = 0;
             foreach (char c in str.ToLower())
             {
                 int cNumValue = (int) (c - 'a');
                 toggleBit(ref bitVector, cNumValue);
             }
             return (bitVector == 0 || hasOnlyOneBitSet(bitVector));
         }

        /* **************************************************************
         *                    Testing Main Method!!!
         * *************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("Are these strings permutations of a palindrome?");

            Console.WriteLine("\nUsing Hash:");
            Console.WriteLine("TactCoa is: {0}", IsPalindromePermutationWithHash("TactCoa"));
            Console.WriteLine("aabab is: {0}", IsPalindromePermutationWithHash("aabab"));
            Console.WriteLine("ppellaa is: {0}", IsPalindromePermutationWithHash("ppellaa"));
            Console.WriteLine("LolPol is: {0}", IsPalindromePermutationWithHash("LolPol"));

            Console.WriteLine("\nUsing BitVector:");
            Console.WriteLine("TactCoa is: {0}", IsPalindromePermutationWithBitVector("TactCoa"));
            Console.WriteLine("aabab is: {0}", IsPalindromePermutationWithBitVector("aabab"));
            Console.WriteLine("ppellaa is: {0}", IsPalindromePermutationWithBitVector("ppellaa"));
            Console.WriteLine("LolPol is: {0}", IsPalindromePermutationWithBitVector("LolPol"));
        }
    }
}
