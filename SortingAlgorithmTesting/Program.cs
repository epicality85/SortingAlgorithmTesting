using System.Text;

namespace SortingAlgorithmTesting
{
    internal class Program
    {
        private static bool _isExiting = false;
        private static bool _isExecuting = false;

        private static List<SortingAlgorithmBase>? sortingMethods;

        static void Init(int _listLength)
        {
            sortingMethods = new List<SortingAlgorithmBase>()
            {
                //new SingleSelection(_listLength),
                //new SingleSelectionWOC(_listLength),
                new BubbleSort(_listLength),
                new BubbleSortWOC(_listLength),
                //new DoubleSelection(_listLength),
                //new DoubleSelectionWOC(_listLength)
            };

            _isExecuting = true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my testing app, where we test the efficiency of different sorting algorithms!");
            Console.WriteLine("I have recently begun studying computer science for a career change, and these are some of my learnings.");

            Console.WriteLine();

            while (!_isExiting && !_isExecuting)
            {
                Console.WriteLine("How many items would you like to test in the list? ");
                int listLength = 0;
                listLength = int.Parse(Console.ReadLine());

                if (listLength > 0)
                {
                    Init(listLength);
                }
                else
                {
                    _isExecuting = true;
                    break;
                }
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
