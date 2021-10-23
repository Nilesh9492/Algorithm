using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Permutation
    {
        public static String swapping(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        public static void permute(String str, int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = swapping(str, start, i);
                    permute(str, start + 1, end);
                    str = swapping(str, start, i);
                }
            }
        }
    }
}

