using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    /// <summary>
    /// A class contatining the heap sort algorithm and supporting methods.
    /// Algorithm adapted from: https://www.geeksforgeeks.org/heap-sort/
    /// </summary>
    public static class HeapSort
    {

        /// <summary>
        /// The method that calls the Heap sort
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        public static void Sort<T>(List<T> l) where T : IComparable
        {
            for (int i = l.Count / 2 - 1; i >= 0; i--)
                Heapify(l, i);

            for (int i = l.Count - 1; i >= 0; i--)
            {
                Swap(l, 0, i);
                Heapify(l, i);
            }
        }
        /// <summary>
        /// Arranges list into heap sorted order
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        /// <param name="i">The index to "heapify"</param>
        private static void Heapify<T>(List<T> l, int i) where T : IComparable
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < l.Count && l[left].CompareTo(l[largest]) < 0)
                largest = left;

            if (right < l.Count && l[right].CompareTo(l[largest]) < 0)
                largest = right;

            if (largest != i)
            {
                Swap(l, i, largest);
                Heapify(l, largest);
               
              
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
