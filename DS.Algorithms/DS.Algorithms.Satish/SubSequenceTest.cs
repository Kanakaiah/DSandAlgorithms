using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish
{
    class SubSequenceTest
    {
        internal static void Run()
        {
            int[] seqArray = { 3, 4, -4, 7, 9, -4 };
            Console.WriteLine("Subscequence Sum of the Array : " + SubSequenceSum.displaySubSum(seqArray));
            seqArray = new int[7] { 2, 4, -6, 8, 9, -3, 5 };
            Console.WriteLine("Subscequence Sum of the Array : " + SubSequenceSum.displaySubSum(seqArray));
        }
    }
}
