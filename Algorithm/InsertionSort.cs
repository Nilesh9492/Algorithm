using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        public void Sort(string[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                string max = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].Length > max.Length)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = max;
            }
        }
        public void PrintArray(string[] array)
        {
            Console.WriteLine("The Sorted array is : ");
            int n = array.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
        }
        
    }
}
