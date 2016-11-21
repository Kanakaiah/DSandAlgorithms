using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class HourGlass
    {

        public static int LargestHourGlass(int[][] arr)
        {


            int max = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if ((arr.Length - i) < 3)
                    break;

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if ((arr.GetLength(0) - j) < 3)
                        break;

                    temp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (i == 0 & j == 0)
                        max = temp;
                    if (temp > max)
                        max = temp;

                }
            }

            return max;
        }

    }


    public class HourGlassTest
    {

        public static void Run()
        {
            //input:
            int[][] arr = new int[6][] { new int[] { 1, 1, 1, 0, 0, 0 },
                                         new int[] { 0, 1, 0 ,0 ,0 ,0 },
                                         new int[] { 1, 1, 1, 0, 0, 0 },
                                         new int[] { 0 ,0 ,2 ,4, 4, 0 },
                                         new int[] { 0 ,0, 0, 2, 0, 0 },
                                         new int[] { 0, 0, 1, 2, 4, 0 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine(HourGlass.LargestHourGlass(arr));
        }

    }
}
