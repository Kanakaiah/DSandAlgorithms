using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class HourGlass
    {
        public static int MaxSum(int[,] inMatrix)
        {
            Console.WriteLine("Maximum Hourglass Sum Demo:");
            Console.WriteLine();
            Console.WriteLine("Input Matrix");
            Console.WriteLine();
            for(int i = 0; i < inMatrix.GetLength(0); i++)
            {
                for (int j =0; j < inMatrix.GetLength(1); j++)
                {
                    Console.Write(inMatrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            int sum = 0;
            int maxSum = 0;
            for(int i = 0; i < inMatrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < inMatrix.GetLength(1) - 2; j++)
                {
                    sum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(inMatrix[i, j + k]);
                        sum += inMatrix[i, j + k];
                        Console.Write(' ');
                        if(k == 1)
                        {
                            Console.Write(inMatrix[i + k, j + k]);
                            sum += inMatrix[i + k, j + k];
                        }
                       

                        Console.Write(' ');
                        Console.Write(inMatrix[i + 2, j + k]);
                        sum += inMatrix[i + 2, j + k];
                       Console.Write(' ');
                    }
                    Console.WriteLine();
                    if (sum > maxSum)
                        maxSum = sum;
                    Console.WriteLine();
                    Console.WriteLine("Sum :" + sum);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            return maxSum;
        }
    }
}
