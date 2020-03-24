using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    /// <summary>
    /// A class contatining the insertion sort algorithm and supporting methods.
    /// Algorithm adapted from: https://www.geeksforgeeks.org/insertion-sort/
    /// </summary>
    public static class InsertionSort
    {
        /// <summary>
        /// The method that calls the insertion sort
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        public static void Sort<T>(List<T> l) where T : IComparable
        {
            for(int i = 1; i < l.Count; i++)
            {
                T key = l[i];

                int j;

                for(j = i - 1; j >= 0 && l[j].CompareTo(key) > 0; j--)
                {
                    l[j + 1] = l[j];
                }

                l[j + 1] = key;
            }
        }


    }
}
