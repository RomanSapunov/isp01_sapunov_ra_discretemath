using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArraySort
    {
        public static int[] Bubble(int[] array)
        {
            if (array == null || array.Length < 2)
                return array;

            while (true)
            {
                bool flag = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag) break;
            }

            return array;
        }

        public static int[] Select(int[] array)
        {
            if (array == null || array.Length < 2)
                return array;

            for (int i = 0; i < array.Length; i++)
            {
                int max = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[max] < array[j])
                    {
                        int temp = array[max];
                        array[max] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
