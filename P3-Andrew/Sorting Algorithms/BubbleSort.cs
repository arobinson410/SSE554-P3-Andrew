using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    /// <summary>
    /// A class contatining the bubble sort algorithm and supporting methods.
    /// Algorithm adapted from: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-3.php
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// The method that calls the bubble sort
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        public static void Sort<T>(List<T> l) where T : IComparable
        {
            for(int i = 0; i <= l.Count - 2; i++)
            {
                for(int j = 0; j <= l.Count - 2; j++)
                {
                    if(l[j].CompareTo(l[j + 1]) > 0)
                    {
                        Swap(l, j, j + 1);
                    }
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
