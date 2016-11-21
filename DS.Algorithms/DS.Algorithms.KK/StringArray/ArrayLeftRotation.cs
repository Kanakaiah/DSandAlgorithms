using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{

    /// <summary>
    /// 13. Given an array of n integers and a number, d , perform d left rotations on the array. 
    /// Then print the updated array as a single line of space-separated integers
    /// Sample Input
    /// 5 4
    /// 1 2 3 4 5
    /// Sample Output
    /// 5 1 2 3 4
    /// </summary>
    class ArrayLeftRotation
    {
        public static int[] RotateLeft(int[] array, int numberofrotation)
        {
            //numberofrotation = numberofrotation >= array.Length ? numberofrotation % array.Length : numberofrotation;
            int temp = 0;

            while (numberofrotation > 0)
            {
                temp = array[0];

                for (int i = 0; i < array.Length-1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = temp;

                numberofrotation--; 
            }

            return array;
        }
    }

    public class ArrayLeftRotationTest
    {

        public static void Run()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After Left Rotation");


            arr = ArrayLeftRotation.RotateLeft(arr, 4);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

    }
}
