using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal class SingleSelection : SortingAlgorithmBase
    {
        private int[] _sortedList;
        Stopwatch _stopwatch;

        public SingleSelection(int listLength) : base(listLength)
        {
            _stopwatch = new Stopwatch();
            _sortedList = new int[listLength];
        }

        public override void Init()
        {
            base.Init();
            Array.Copy(_unsortedList, _sortedList, _unsortedList.Length);
        }

        public override void Sort()
        {
            _stopwatch.Start();

            for(int i = 0; i < _sortedList.Length - 1; i++)
            {
                int smallestIndex = i;

                for (int j = i + 1; j < _sortedList.Length; j++)
                {
                    if (_sortedList[j] < _sortedList[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                if(smallestIndex != i)
                {
                    int temp1 = _sortedList[smallestIndex];
                    int temp2 = _sortedList[i];

                    _sortedList[i] = temp1;
                    _sortedList[smallestIndex] = temp2;
                }
            }

            _stopwatch.Stop();
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            TimeSpan timeTaken = _stopwatch.Elapsed;

            //sb.AppendLine("Unsorted:");
            //foreach(int i in _unsortedList)
            //{
            //    sb.Append(i.ToString());
            //    sb.Append(", ");
            //}

            //sb.AppendLine();

            //sb.AppendLine("  Sorted:");
            //foreach (int i in _sortedList)
            //{
            //    sb.Append(i.ToString());
            //    sb.Append(", ");
            //}


            sb.AppendLine("Single Selection Sort stats:");
            sb.AppendLine("Operation took: " + timeTaken.ToString(@"ss\.ffffff") + " seconds to complete.");

            return sb.ToString();
        }
    }
}