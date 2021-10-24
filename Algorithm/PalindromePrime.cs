using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PalindromePrime
    {
        public void Input()
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());
            PalindromePrime.checkPrime(num1);
            PalindromePrime.checkPrime(num2);
            bool anagram = PalindromePrime.FindAnagram(Convert.ToString(num1), Convert.ToString(num2));
            bool palindormres = PalindromePrime.Palindrome(num1);
            if (anagram)
            {
                Console.WriteLine("Both values are Anagrams");

            }
            else
            {
                Console.WriteLine("Both the values are not Anagrams");
            }
            if (palindormres)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not a Palindrome");
            }
        }
        public static int checkPrime(int number)
        {
            int a = 1;
            if (number == 1 || number == 0) { a = 0; }

            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    a = 0;
                    break;
                }
            }
            return a;
        }
        public static bool Palindrome(int number)
        {
            int rem, sum = 0, temp;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                number = number / 10;
                sum = sum * 10 + rem;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FindAnagram(string string1, string string2)
        {

            char[] ch1 = string1.ToLower().ToCharArray();
            char[] ch2 = string2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newString1 = new string(ch1);
            string newString2 = new string(ch2);
            if (newString1 == newString2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
