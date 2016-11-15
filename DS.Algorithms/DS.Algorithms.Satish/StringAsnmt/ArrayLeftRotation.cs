using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class ArrayLeftRotation
    {
        public static void Rotate(int[] inArray, int rotateNum)
        {
            Console.WriteLine();
            Console.WriteLine("Array Rotation by " + rotateNum + " times");
            Console.WriteLine();
            Console.WriteLine("Input Array..");
            Console.WriteLine();
            for (int i = 0; i < inArray.Length; i++)
            {
                Console.Write(inArray[i]);
                Console.Write(' ');
            }
            Console.WriteLine();

            // Array Rotation Logic...Copying the elements to the same Array using Array.Copy
            for (int i = 0; i < rotateNum; i++)
            {
                int rotateValue = inArray[0];
                //inArray.CopyTo(inArray,)
                Array.Copy(inArray, 1, inArray, 0, inArray.Length - 1);
                inArray[inArray.Length - 1] = rotateValue;
            }

            Console.WriteLine();
            Console.WriteLine("Output Array after rotation..");
            Console.WriteLine();

            for (int i = 0; i < inArray.Length; i++)
            {
                Console.Write(inArray[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
