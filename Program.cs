using System;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15] {2, 5, -4, 11, 0, 15, 22, 67, 51, 6, 65, 23, 89, 1, 40};

            Print(arr, "Before:");

            // var sorted = Insertion.Sort(arr);
            var sorted = SelectionSort.Sort(arr);

            Print(sorted, "After:");

        }

        private static void Print(int[] arr, string msg){

            Console.WriteLine(msg);

            foreach (int i in arr)
            {
                Console.Write(i.ToString() + "  ");
            }
            Console.WriteLine(string.Empty);
        }
    }
}
