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
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Bubble Sort");
            Console.WriteLine("5. Merge Sort");
            Console.WriteLine("6. Anagram Detection");
            Console.WriteLine("7. Prime Number");
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
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    string[] array = { "Hello", "World", "Good", "Morning" };
                    insertionSort.Sort(array);
                    insertionSort.PrintArray(array);
                    break;
                case 4:
                    BubbleSort bubbleSort = new BubbleSort();
                    int[] arr = { 2,7,3,9,1,10 };
                    bubbleSort.Sort(arr);
                    bubbleSort.PrintArray(arr);
                    break;
                case 5:
                    int[] array1 = { 6,2,8,3,9,12,10 };
                    MergeSort.Sort(array1, 0, array1.Length - 1);
                    MergeSort.PrintArray(array1);
                    break;
                case 6:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;
                case 7:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
                default:
                    break;
            }
                       
            
        }
    }
}
