using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    public static class QuickSort
    {
        //Algorithm adapted from: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php
        public static void Sort<T>(List<T> l, int left = default, int right = default) where T : IComparable
        {
            if (left == default)
                left = 0;
            if (right == default)
                right = l.Count - 1;

            int pivot = Partition(l, left, right);

            if (pivot > 1)
                Sort(l, left, pivot - 1);
            if(pivot + 1 < right)
            {
                Sort(l, pivot + 1, right);
            }
        }

        private static int Partition<T>(List<T> l, int left, int right) where T : IComparable
        {
            T pivot = l[left];
            while (true)
            {

                while (l[left].CompareTo(pivot) < 0 )
                {
                    left++;
                }

                while (l[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (l[left].CompareTo(l[right]) == 0) return right;

                    Swap(l, left, right);
                }
                else
                {
                    return right;
                }
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
