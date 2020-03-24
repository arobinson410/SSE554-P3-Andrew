using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            List<int> list = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                list.Add(rand.Next());
            }

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------");

            Sorting_Algorithms.QuickSort.Sort(list);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
