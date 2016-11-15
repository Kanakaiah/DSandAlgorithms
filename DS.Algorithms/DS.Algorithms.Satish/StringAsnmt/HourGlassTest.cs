using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class HourGlassTest
    {
        internal static void Run()
        {
            int[,] input = { { 1, 1, 1, 0, 0, 0 },
                             { 0, 1, 0, 0, 0, 0 },
                             { 1, 1, 1, 0, 0, 0 },
                             { 0, 0, 2, 4, 4, 0 },
                             { 0, 0 ,0 ,2, 0, 0 },
                             { 0, 0, 1, 2, 4, 0 }
            };

            Console.WriteLine("Maximum HourGlass Sum -> " + HourGlass.MaxSum(input));
            Console.WriteLine();
        }
    }
}
