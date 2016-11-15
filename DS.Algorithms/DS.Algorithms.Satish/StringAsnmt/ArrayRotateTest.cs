using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class ArrayRotateTest
    {
        internal static void Run()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int rotations = 4;
            ArrayLeftRotation.Rotate(input, rotations);
        }
    }
}
