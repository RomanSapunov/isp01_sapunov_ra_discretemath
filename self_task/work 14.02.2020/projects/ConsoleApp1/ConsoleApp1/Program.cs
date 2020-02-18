using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static List<int> PositiveList(List<int> list)
        {
            List<int> resList = new List<int>();

            for (int i = 0; i < list.Count; i++)
                if (list[i] > 0)
                    resList.Add(list[i]);

            return resList;
        }

        static List<int> InsertList(List<int> list, int x)
        {
            for (int i = 0; i < list.Count - 1; i++)
                if (list[i] > 0)
                    list.Add(x);

            return list;
        }

        static List<int> ClearingList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                    i--;
                }

            return list;
        }

        static List<int> StringToIntList(List<string> list)
        {
            List<int> resList = new List<int>();

            for (int i = 0; i < list.Count; i++)
                if (int.TryParse(list[i], out int x))
                    resList.Add(x);

            return resList;
        }
    }
}
