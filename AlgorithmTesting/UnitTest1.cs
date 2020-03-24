using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTesting
{
    [TestClass]
    public class UnitTest1
    {
        const int DATASIZE = 12500;

        List<int> testList = new List<int>();

        [TestInitialize]
        public void PrepTest()
        {
            Random random = new Random();
            for(int i = 0; i < DATASIZE; i++)
            {
                testList.Add(random.Next());
            }
        }

        [TestMethod]
        public void BubbleSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.BubbleSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }

        [TestMethod]
        public void CombSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.CombSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }

        [TestMethod]
        public void HeapSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.HeapSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }

        [TestMethod]
        public void InsertionSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.InsertionSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }

        [TestMethod]
        public void MergeSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.MergeSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }

        [TestMethod]
        public void QuickSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.QuickSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }

        [TestMethod]
        public void SelectionSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.SelectionSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }

        [TestMethod]
        public void ShellSort()
        {
            List<int> dataSet = new List<int>(testList);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            P3_Andrew.Sorting_Algorithms.ShellSort.Sort(dataSet);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Debug.WriteLine(elapsedTime);
        }
    }
}
