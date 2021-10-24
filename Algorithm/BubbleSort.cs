using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSort<T> where T : IComparable
    {
        public void Sort(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1])<0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public void PrintArray(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
