using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 5, -34, 0, 76 };
            ArraySort.BubbleSort(array1);
            Console.Write("Bubble: ");
            foreach (var i in array1)
                Console.Write(i + " ");

            Console.WriteLine("\n");

            int[] array2 = { 3, 5, -34, 0, 76 };
            ArraySort.SelectSort(array2);
            Console.Write("Select: ");
            foreach (var i in array2)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}