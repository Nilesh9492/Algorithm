using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Permutation of String ");
            Console.WriteLine("2. Binary Search the Word ");
            Console.Write("Enter your choice of operation : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter The  String : ");
                    string str = Console.ReadLine();
                    int length = str.Length;
                    Permutation.permute(str, 0, length - 1);
                    break;
                case 2:
                    string filepath = File.ReadAllText(@"E:\NILESH\C#\Algorithm\words.txt");
                    List<string> list = new List<string>(filepath.Split(' '));
                    list.Sort();
                    BinarySearch.Search(list);
                    break;
                default:
                    break;
            }
                       
            
        }
    }
}
