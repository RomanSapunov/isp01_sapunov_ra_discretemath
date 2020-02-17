using System;

namespace ConsoleApp1
{
    class ArraySort
    {
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            while (true)
            {
                bool tmp = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        tmp = true;
                    }
                }
                if (!tmp) break;
            }
        }

        public static void SelectSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                int max = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[max] < array[j])
                    {
                        Swap(array, max, j);
                    }
                }
            }
        }
    }
}
