using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Bhanu
{
    public class ArrayBasedProblems
    {
        public static void Test_MaxSubArraySum()
        {
            int[][] inputArrays = new int[][]
            {
                new int[] { -2, -3, 4, -1, -2, 1, 5, -3},
                new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4},
                 new int[] {8, -1, 6, -2, -4, 7}
            };

            foreach (int[] ar in inputArrays)
            {
                Console.WriteLine(ar.Aggregate("", (accum, num) => accum + "," + num.ToString()));
                Console.WriteLine(MaxSubArraySum(ar));
            }
        }

        private static int MaxSubArraySum(int[] ar)
        {
            int runningSum = ar[0];
            int maxSum = ar[0];
            int i = 1;

            while (i < ar.Length)
            {
                if (runningSum + ar[i] > maxSum)
                {
                    if (runningSum < 0)
                    {
                        runningSum = ar[i];
                        maxSum = ar[i];
                    }
                    else
                    {
                        maxSum = runningSum + ar[i];
                        runningSum = maxSum;
                    }
                }
                else
                {
                    if (runningSum < 0)
                    {
                        runningSum = 0;
                    }
                    else
                    {
                        runningSum = runningSum + ar[i];
                    }
                }
                i++;
            }

            return maxSum;
        }
    }
}
