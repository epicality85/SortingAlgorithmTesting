using System.Text;

namespace SortingAlgorithmTesting
{
    internal class Program
    {
        private static bool _isExiting = false;
        private static bool _isExecuting = false;

        private static List<SortingAlgorithmBase> sortingMethods = new();
        private static int[] listLengths = { 10, 100, 1000, 10000, 100000};//, 1000000 };

        static bool Init()
        {
            for (int i = 0; i < listLengths.Length; i++)
            {
                sortingMethods.Add(new BubbleSort(listLengths[i]));
            }

            for (int i = 0; listLengths.Length > i; i++)
            {
                sortingMethods.Add(new BubbleSortWOC(listLengths[i]));
            }

            for (int i = 0; i < listLengths.Length; i++)
            {
                sortingMethods.Add(new SingleSelection(listLengths[i]));
            }

            for (int i = 0; listLengths.Length > i; i++)
            {
                sortingMethods.Add(new SingleSelectionWOC(listLengths[i]));
            }

            _isExecuting = true;

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my testing app, where we test the efficiency of different sorting algorithms!");
            Console.WriteLine("I have recently begun studying computer science for a career change, and these are some of my learnings.");

            Console.WriteLine();

            while (!_isExiting && !_isExecuting)
            {
                if(Init())
                {
                    _isExecuting = true;
                }
                else
                {
                    _isExiting = true;
                    break;
                }
                //Console.WriteLine("How many items would you like to test in the list? ");
                //int listLength = 0;
                //listLength = int.Parse(Console.ReadLine());

                //if (listLength > 0)
                //{
                //    Init(listLength);
                //}
                //else
                //{
                //    _isExecuting = true;
                //    break;
                //}
            }

            if (_isExiting)
            {
                Console.WriteLine("Exit initiated...Thanks for testing!");
                return;
            }
            else
            {
                foreach (var method in sortingMethods)
                {
                    method.Init();
                    method.Sort();
                    Console.WriteLine(method.Stats());
                }
            }

            Console.WriteLine("Testing complete!");
        }
    }
}
