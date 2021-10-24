using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Anagram
    {
        public void CheckAnagram()
        {
            Console.Write("Enter the First Word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter the Second Word:");
            string word2 = Console.ReadLine();
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string newWord1 = new string(char1);
            string newWord2 = new string(char2);

            if (newWord1 == newWord2)
            {
                Console.WriteLine("Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }
        }
    }
}
