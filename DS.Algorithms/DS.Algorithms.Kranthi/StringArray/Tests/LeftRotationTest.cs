using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class LeftRotationTest
    {
        internal static void Run()
        {
            int numbers = 5;
            int rotations = 4;
            Console.WriteLine("Rotating {0} integers {1} times gives:", numbers, rotations);
            LeftRotation.Algorithm(numbers, rotations);

            numbers = 10;
            rotations = 1;            
            Console.WriteLine("Rotating {0} integers {1} times gives:", numbers, rotations);
            LeftRotation.Algorithm(numbers, rotations);

            numbers = 10;
            rotations = 0;
            Console.WriteLine("Rotating {0} integers {1} times gives:", numbers, rotations);
            LeftRotation.Algorithm(numbers, rotations);
        }
    }
}
