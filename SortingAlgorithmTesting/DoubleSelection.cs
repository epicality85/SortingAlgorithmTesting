using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal class DoubleSelection : SortingAlgorithmBase
    {
        public DoubleSelection(int listLength) : base(listLength) { }

        public override void Init()
        {
            Console.WriteLine("Begin Init of Double Selection Algorithm");
            base.Init();
            Console.WriteLine("Init of Double Selection Algorithm complete");
        }

        public override void Sort()
        {
            Console.WriteLine("Begin Sort method of Double Selection Algorithm");


            Console.WriteLine("Sort complete of Double Selection Algorithm");
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            return sb.ToString();
        }
    }
}
