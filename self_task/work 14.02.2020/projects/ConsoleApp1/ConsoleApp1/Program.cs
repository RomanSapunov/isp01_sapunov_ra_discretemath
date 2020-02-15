using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //PositiveList
            //List<int> list = new List<int>() { 3, -9, 7, -54, 0 };
            //list = PositiveList(list);
            //foreach (var i in list)
            //Console.Write(i + " ");

            // InsertList
            //List<int> list = new List<int>() { 3, -9, 7, -54, 5 };
            //list = InsertList(list, 0);
            //foreach (var i in list)
            //    Console.Write(i + " ");

            //ClearingList
            //List<int> list = new List<int>() { 3, -9, 7, -54, 5 };
            //list = ClearingList(list);
            //foreach (var i in list)
            //    Console.Write(i + " ");

            // StringToIntList
            //List<int> list;
            //List<string> stringList = new List<string>() { "543", "5f43", "4513", "5a3", "-43" };
            //list = StringToIntList(stringList);
            //foreach (var i in list)
            //    Console.Write(i + " ");

            Console.ReadKey();
        }

        static List<int> PositiveList(List<int> list)
        {
            List<int> resList = new List<int>();

            for (int i = 0; i < list.Count(); i++)
                if (list[i] > 0)
                    resList.Add(list[i]);

            return resList;
        }

        static List<int> InsertList(List<int> list, int x)
        {
            for (int i = 0; i < list.Count() - 1; i++)
            {
                if (list[i] > 0)
                {
                    list[i + 1] = x;
                    i++;
                }
            }

            return list;
        }

        static List<int> ClearingList(List<int> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }

            return list;
        }

        static List<int> StringToIntList(List<string> list)
        {
            List<int> resList = new List<int>();

            for (int i = 0; i < list.Count(); i++)
            {
                if (int.TryParse(list[i], out int x))
                    resList.Add(x);
            }

            return resList;
        }
    }
}
