using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 5, -34, 0, 76 };
            array1 = ArraySort.Bubble(array1);
            Console.Write("Bubble: ");
            foreach (var i in array1)
                Console.Write(i + " ");

            Console.WriteLine("\n");

            int[] array2 = { 3, 5, -34, 0, 76 };
            array2 = ArraySort.Select(array2);
            Console.Write("Select: ");
            foreach (var i in array2)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}