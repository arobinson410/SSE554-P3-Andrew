using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    /// <summary>
    /// A class contatining the selection sort algorithm and supporting methods.
    /// Algorithm adapted from: https://www.geeksforgeeks.org/selection-sort/
    /// </summary>
    public static class SelectionSort
    {
        /// <summary>
        /// The method that calls the selection sort
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
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
