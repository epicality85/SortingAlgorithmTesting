using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTesting
{
    internal abstract class SortingAlgorithmBase
    {
        private readonly HashSet<int> _generatedUniqueNumbers;
        protected int[] _unsortedList;

        public SortingAlgorithmBase(int listLength)
        {
            _generatedUniqueNumbers = new HashSet<int>(listLength);
            _unsortedList = new int[listLength];
        }

        public virtual void Init()
        {
            Random r = new Random();
            int listLength = _unsortedList.Length;
            for (int i = 0; i < listLength; i++)
            {
                _generatedUniqueNumbers.Add(r.Next(0, listLength * 10));
            }

            _unsortedList = _generatedUniqueNumbers.ToArray();
        }

        public abstract void Sort();

        public abstract string Stats();
    }
}
