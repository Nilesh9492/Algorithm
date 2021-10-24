using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MergeSort<T> where T : IComparable
    {
        public static void Merge(T[] array1, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            T[] left = new T[n1];
            T[] right = new T[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                left[i] = array1[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                right[j] = array1[m + 1 + j];
            }
            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i].CompareTo(right[j])<0)
                {
                    array1[k] = left[i];
                    i++;
                }
                else
                {
                    array1[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array1[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array1[k] = right[j];
                j++;
                k++;
            }
        }
        public static void Sort(T[] array1, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                Sort(array1, l, m);
                Sort(array1, m + 1, r);
                Merge(array1, l, m, r);
            }
        }
        public static void PrintArray(T[] array1)
        {
            int n = array1.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array1[i] + " ");
            Console.WriteLine();
        }
    }
}
