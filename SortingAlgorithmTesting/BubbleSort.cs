using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal class BubbleSort : SortingAlgorithmBase
    {
        private int[] sortedList;
        bool swapped = false;

        Stopwatch stopwatch;

        public BubbleSort(int listLength) : base(listLength) 
        {
            sortedList = new int[listLength];
            stopwatch = new Stopwatch();
        }

        public override void Init()
        {
            Console.WriteLine("Begin Init of Bubble Sort Algorithm");

            base.Init();
            Array.Copy(_unsortedList, sortedList, _unsortedList.Length);

            Console.WriteLine("Init of Bubble Sort Algorithm complete");
        }

        public override void Sort()
        {
            Console.WriteLine("Begin Sort method of Bubble Sort Algorithm");
            stopwatch.Start();
            do
            {
                swapped = false;
                for (int i = 0; i < sortedList.Length - 1; i++)
                {
                    int temp1 = sortedList[i];
                    int temp2 = sortedList[i + 1];
                    if (temp1 > temp2)
                    {
                        sortedList[i] = temp2;
                        sortedList[i + 1] = temp1;
                        swapped = true;
                    }
                }
            } 
            while (swapped != false);
            stopwatch.Stop();

            Console.WriteLine("Sort complete of Bubble Sort Algorithm");
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            TimeSpan timeTaken = stopwatch.Elapsed;
            sb.AppendLine("Operation took: " + timeTaken.ToString(@"ss\.ffffff") + " seconds to complete.");

            return sb.ToString();
        }
    }
}
