using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 . Permutation of String ");
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            int length = str.Length;
            Permutation.permute(str, 0, length - 1);
        }
    }
}
