using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimeNumber
    {
        int a = 0;
        public void Prime()
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine(i + " ");
                }
                a = 0;
            }
        }
    }
}
