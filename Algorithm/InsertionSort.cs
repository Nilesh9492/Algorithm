using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort<T> where T : IComparable
    {
        public void Sort(T[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                T max = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo( max)>0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = max;
            }
        }
        public void PrintArray(T[] array)
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
