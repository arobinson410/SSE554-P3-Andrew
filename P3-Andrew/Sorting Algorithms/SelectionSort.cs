using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    public static class SelectionSort
    {
        //Algorithm adapted from: https://www.geeksforgeeks.org/selection-sort/
        public static void Sort<T>(List<T> l) where T : IComparable
        {
            int min_index;

            for(int i = 0; i < l.Count - 1; i++)
            {
                min_index = i;

                for(int j = i + 1; j < l.Count; j++)
                {

                    if(l[j].CompareTo(l[min_index]) < 0)
                    {
                        min_index = j;
                    }
                }

                Swap(l, min_index, i);
            }
        }

        private static void Swap<T>(List<T> l, int a, int b) where T : IComparable
        {
            T temp = l[a];
            l[a] = l[b];
            l[b] = temp;
        }

    }
}
