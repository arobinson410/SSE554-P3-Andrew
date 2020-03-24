using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace P3_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vals = { 1000, 5000, 10000, 15000, 20000, 25000, 30000, 35000, 40000, 45000, 50000 };
            int toBeGenerated = 0;

            Random rand = new Random();

            List<int> list = new List<int>();

            foreach(int val in vals)
            {
                for (int i = 0; i < vals[toBeGenerated]; i++)
                {
                    list.Add(rand.Next());
                }

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(val.ToString(), FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, list);
                stream.Close();
                list.Clear();

                toBeGenerated++;
            }
            


        }
    }
}
