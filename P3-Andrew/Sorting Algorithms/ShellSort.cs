using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    public static class ShellSort
    {
        //Algorithm adapted from: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-1.php
        public static void Sort<T>(List<T> l) where T : IComparable
        {
            int inc = 3;
            int j;
            T temp;

            while(inc > 0)
            {
                for(int i = 0; i < l.Count; i++)
                {
                    j = i;
                    temp = l[i];

                    while((j >= inc) && (l[j - inc].CompareTo(temp) > 0))
                    {
                        l[j] = l[j - inc];
                        j = j - inc;
                    }

                    l[j] = temp;
                }

                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

    }
}
