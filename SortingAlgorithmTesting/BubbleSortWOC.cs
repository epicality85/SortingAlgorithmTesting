using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal class BubbleSortWOC : SortingAlgorithmBase
    {
        private int[] sortedList;
        private long _operations;

        public BubbleSortWOC(int listLength) : base(listLength)
        {
            sortedList = new int[listLength];
            _operations = 0;
        }

        public override void Init()
        {
            base.Init();
            Array.Copy(_unsortedList, sortedList, _unsortedList.Length);
        }

        public override void Sort()
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < sortedList.Length - 1; i++)
                {
                    _operations++;
                    int temp1 = sortedList[i];
                    int temp2 = sortedList[i + 1];
                    if (temp1 > temp2)
                    {
                        sortedList[i] = temp2;
                        sortedList[i + 1] = temp1;
                        swapped = true;

                        _operations++;
                    }
                }
                _operations++;
            }
            while (swapped != false);
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendLine("Bubble Sort (with ops counter) stats:");
            sb.AppendLine("Operation took: " + _operations + " operations to complete.");

            return sb.ToString();
        }
    }
}
