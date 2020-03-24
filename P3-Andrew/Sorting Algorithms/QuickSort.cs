using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    /// <summary>
    /// A class contatining the quick sort algorithm and supporting methods.
    /// Algorithm adapted from: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php
    /// </summary>
    public static class QuickSort
    {

        public static bool SortAsync = false;

        /// <summary>
        /// The method that calls the quick sort
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        public static async Task Sort<T>(List<T> l, int left = default, int right = default) where T : IComparable
        {
            if (left == default)
                left = 0;
            if (right == default)
                right = l.Count - 1;

            int pivot = Partition(l, left, right);

            if (SortAsync)
            {
                if (pivot > 1)
                    await Sort(l, left, pivot - 1);
                if (pivot + 1 < right)
                {
                    await Sort(l, pivot + 1, right);
                }
            }
            else
            {
                if (pivot > 1)
                    Sort(l, left, pivot - 1).RunSynchronously();
                if (pivot + 1 < right)
                {
                    Sort(l, pivot + 1, right).RunSynchronously();
                }
            }
        }
    
        /// <summary>
        /// Finds a point to split the list
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        /// <param name="left">Left most point to compare</param>
        /// <param name="right">Right most point to compare</param>
        /// <returns>A point to split the list</returns>
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

        /// <summary>
        /// Supporting method to swap to values in a list
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">List with values that need to be swapped</param>
        /// <param name="a">First index to be swapped</param>
        /// <param name="b">Second index to be swapped</param>
        private static void Swap<T>(List<T> l, int a, int b) where T : IComparable
        {
            T temp = l[a];
            l[a] = l[b];
            l[b] = temp;
        }
    }
}
