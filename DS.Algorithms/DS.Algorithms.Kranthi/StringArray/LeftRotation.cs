using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class LeftRotation
    {
        internal static void Algorithm(int arraySize, int rotations)
        {
            if (rotations < 0)
                throw new InvalidOperationException("Rotations cannot be negative");

            if (arraySize < 0)
                throw new InvalidOperationException("Array Size cannot be negative");

            int[] array = new int[arraySize];
            
            Console.WriteLine("Input:");
            for (int index = 0; index < arraySize; index++)
            {
                array[index] = index + 1;
                Console.Write(array[index]);
                Console.Write(" ");
            }

            int[] rotatedArray = new int[arraySize];
            for (int index = 0; index < arraySize; index++)
            {
                rotatedArray[index] = array[(index + rotations) % arraySize];
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Output:");
            for (int index = 0; index < arraySize; index++)
            {

                Console.Write(rotatedArray[index]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
