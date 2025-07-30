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
        private Stopwatch _stopwatch;

        public BubbleSort(int listLength) : base(listLength) 
        {
            sortedList = new int[listLength];
            _stopwatch = new Stopwatch();
        }

        public override void Init()
        {
            base.Init();
            Array.Copy(_unsortedList, sortedList, _unsortedList.Length);
        }

        public override void Sort()
        {
            _stopwatch.Start();

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < sortedList.Length - 1; i++)
                {
                    int temp1 = sortedList[i];
                    int temp2 = sortedList[i + 1]; // this may be further simplified, for readability, its kept
                    if (temp1 > temp2)
                    {
                        sortedList[i] = temp2;
                        sortedList[i + 1] = temp1;
                        swapped = true;
                    }
                }
            } 
            while (swapped != false);

            _stopwatch.Stop();
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            TimeSpan timeTaken = _stopwatch.Elapsed;
            sb.AppendLine("Bubble Sort stats:");
            sb.AppendLine("Operation took: " + timeTaken.ToString(@"ss\.ffffff") + " seconds to complete.");

            return sb.ToString();
        }
    }
}
