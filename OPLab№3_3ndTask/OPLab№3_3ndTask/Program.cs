using System;
using System.Collections.Generic;
using System.Linq;

namespace OPLab_3_3ndTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { -6, -4, -1, -9, -3, -8, -7 };

            int minInteger = integers.Select(item => {
                if (item > 0)
                {
                    return item;
                }
                else
                {
                    return int.MaxValue;
                }
            }).Min();

            var result = minInteger == int.MaxValue ? 0 : minInteger;
            Console.WriteLine("Min Positive Number = " + result);

        }
    }
}
