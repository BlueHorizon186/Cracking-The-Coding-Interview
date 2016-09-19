using System;

namespace CrackingTheCodingInterview
{
    class Chapter1
    {
        /* **************************************************************
         *      Check if the given strings are one edit away
         *      from each other. They can have either a character
         *      inserted, removed, or replaced.
         * *************************************************************/

         private static bool CheckForExtraChar(string s1, string s2)
         {
             int i = 0;
             int j = 0;

             while (i < s1.Length && j < s2.Length)
             {
                 if (s1[i] != s2[j])
                 {
                     if (i != j) return false;
                     else j++;
                 }

                 else
                 {
                     i++;
                     j++;
                 }
             }
             return true;
         }

         private static bool CheckForReplacedChar(string s1, string s2)
         {
             bool foundDiff = false;
             for (int i = 0; i < s1.Length; i++)
             {
                 if (s1[i] != s2[i])
                 {
                     if (foundDiff) return false;
                     else foundDiff = true;
                 }
             }
             return foundDiff;
         }

         private static bool OneEditAway(string s1, string s2)
         {
             if (s1.Length == s2.Length) return CheckForReplacedChar(s1, s2);
             else if (s1.Length == s2.Length - 1) return CheckForExtraChar(s1, s2);
             else if (s1.Length == s2.Length + 1) return CheckForExtraChar(s2, s1);
             else return false;
         }

        /* **************************************************************
         *                    Testing Main Method!!!
         * *************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("Are these pairs of strings one edit away "
                                + "of each other?");
            Console.WriteLine("Pale, Ple: {0}", OneEditAway("Pale", "Ple"));
            Console.WriteLine("Pales, Pale: {0}", OneEditAway("Pales", "Pale"));
            Console.WriteLine("Pale, Bale: {0}", OneEditAway("Pale", "Bale"));
            Console.WriteLine("Pale, Bake: {0}", OneEditAway("Pale", "Bake"));
        }
    }
}
