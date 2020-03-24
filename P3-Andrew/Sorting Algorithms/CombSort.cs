using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew.Sorting_Algorithms
{
    public static class CombSort
    {
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

        private static void Swap<T>(List<T> l, int a, int b) where T : IComparable
        {
            T temp = l[a];
            l[a] = l[b];
            l[b] = temp;
        }
    }
}
