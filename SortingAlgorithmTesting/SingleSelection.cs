using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal class SingleSelection : SortingAlgorithmBase
    {
        public SingleSelection(int listLength) : base(listLength) { }

        public override void Init()
        {
            Console.WriteLine("Begin Init of Single Selection Algorithm");
            base.Init();
            Console.WriteLine("Init of Single Selection Algorithm complete");
        }

        public override void Sort()
        {
            Console.WriteLine("Begin Sort method of Single Selection Algorithm");


            Console.WriteLine("Sort complete of Single Selection Algorithm");
        }

        public override string Stats()
        {
            StringBuilder sb = new StringBuilder("");

            return sb.ToString();
        }
    }
}