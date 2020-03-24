using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{

    /// <summary>
    /// A class contatining the comb sort algorithm and supporting methods.
    /// Algorithm adapted from: https://www.csharpstar.com/comb-sort-program-csharp/
    /// </summary>
    public static class CombSort
    {
        /// <summary>
        /// The method that calls the comb sort
        /// </summary>
        /// <typeparam name="T">Any type derived from IComparable</typeparam>
        /// <param name="l">A list of type T</param>
        public static void Sort<T>(List<T> l) where T : IComparable
        {
            double gap = l.Count;
            bool swaps = true;

            while(gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while(i + gap < l.Count)
                {
                    int igap = i + (int)gap;

                    if(l[i].CompareTo(l[igap]) > 0)
                    {
                        Swap(l, i, igap);
                        swaps = true;
                    }

                    i++;
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
