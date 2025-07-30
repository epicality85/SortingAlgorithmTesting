using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal class SingleSelectionWOC : SortingAlgorithmBase
    {
        private int[] _sortedList;
        private long _operations = 0;

        public SingleSelectionWOC(int listLength) : base(listLength)
        {
            _sortedList = new int[listLength];
        }

        public override void Init()
        {
            base.Init();
            Array.Copy(_unsortedList, _sortedList, _unsortedList.Length);
        }

        public override void Sort()
        {
            for (int i = 0; i < _sortedList.Length - 1; i++)
            {
                _operations++;
                int smallestIndex = i;

                for (int j = i + 1; j < _sortedList.Length; j++)
                {
                    _operations++;
                    if (_sortedList[j] < _sortedList[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                if (smallestIndex != i)
                {
                    int temp1 = _sortedList[smallestIndex];
                    int temp2 = _sortedList[i];

                    _sortedList[i] = temp1;
                    _sortedList[smallestIndex] = temp2;

                    _operations++;
                }
            }
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendLine("Single Selection (with ops counter) stats:");
            sb.AppendLine("Operation took: " + _operations + " operations to complete.");

            return sb.ToString();
        }
    }
}