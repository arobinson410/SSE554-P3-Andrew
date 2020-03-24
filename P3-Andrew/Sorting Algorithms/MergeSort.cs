using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    /// <summary>
    /// A class contatining the merge sort algorithm and supporting methods.
    ///Algorithm adapted from: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php
    /// </summary>
    public static class MergeSort
    {
        /// <summary>
        /// The method that calls the merge sort
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        public static List<T> Sort<T>(List<T> l) where T : IComparable
        {
            if (l.Count <= 1)
                return l;

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            int middle = l.Count() / 2;

            for(int i = 0; i < middle; i++)
            {
                left.Add(l[i]);
            }
            for(int i = middle; i < l.Count; i++)
            {
                right.Add(l[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }
        /// <summary>
        /// Combines the two lists, ensuring they are in descending order
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="left">A list of type T</param>
        /// <param name="right">A list of type T</param>
        /// <returns>A merged list</returns>
        private static List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable
        {
            List<T> toReturn = new List<T>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().CompareTo(right.First()) <= 0)  //Comparing First two elements to see which is smaller
                    {
                        toReturn.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        toReturn.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    toReturn.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    toReturn.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return toReturn;

        }
    }
}
