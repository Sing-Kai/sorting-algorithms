using System;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[15] {2, 5, -4, 11, 0, 15, 22, 67, 51, 6, 65, 23, 89, 1, 40};
            Insertion.Sort(arr);
        }
    }
}
