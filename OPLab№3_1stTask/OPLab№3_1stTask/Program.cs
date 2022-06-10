using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OPLab_3_1stTask
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { -3, -5, 1, 3, 9, 8 };
            int minValue = Int32.MaxValue;
            int maxValue = Int32.MinValue;
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minValue)
                {
                    minIndex = i;
                    minValue = list[i];
                }
                else if (list[i] > maxValue)
                {
                    maxIndex = i;
                    maxValue = list[i];
                }
            }

            int tempMax = list[maxIndex];
            list[maxIndex] = list[minIndex];
            list[minIndex] = tempMax;

            Console.WriteLine(String.Join("; ", list));
        }
    }
}