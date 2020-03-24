using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTesting
{
    [TestClass]
    public class UnitTest1
    {
        const int DATASIZE = 30000;
        const int AVERAGEVALUES = 10;

        List<int> testList = new List<int>();

        [TestInitialize]
        public void PrepTest()
        { 

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(DATASIZE.ToString(), FileMode.Open, FileAccess.Read);
            testList = (List<int>)formatter.Deserialize(stream);
            stream.Close();
        }


        public long Average(long[] l)
        {
            long sum = 0;
            foreach(long val in l)
            {
                sum += val;
            }

            return sum / (long) AVERAGEVALUES;
        }


        [TestMethod]
        public void BubbleSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.BubbleSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures));
        }
        [TestMethod]
        public void CombSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.CombSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures));
        }
        [TestMethod]
        public void HeapSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.HeapSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures)); ;
        }
        [TestMethod]
        public void InsertionSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.InsertionSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures));
        }
        [TestMethod]
        public void MergeSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.MergeSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures));
        }
        
        public void QuickSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.QuickSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures));
        }
        [TestMethod]
        public void SelectionSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.SelectionSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures));
        }
        [TestMethod]
        public void ShellSort()
        {
            List<int> dataSet = new List<int>(testList);
            long[] measures = new long[AVERAGEVALUES];

            for (int i = 0; i < AVERAGEVALUES; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                P3_Andrew.Sorting_Algorithms.SelectionSort.Sort(dataSet);

                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                measures[i] = ts.Ticks;
            }
            Debug.WriteLine("Average Runtime: " + Average(measures));
        }
    }
}
