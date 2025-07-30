using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal class DoubleSelectionWOC : SortingAlgorithmBase
    {
        private int[] sortedList;

        public DoubleSelectionWOC(int listLength) : base(listLength)
        {
            sortedList = new int[listLength];
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

            Console.WriteLine("Sort complete of Bubble Sort Algorithm");
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            return sb.ToString();
        }
    }
}
