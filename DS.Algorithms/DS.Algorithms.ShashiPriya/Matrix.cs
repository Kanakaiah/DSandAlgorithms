using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.ShashiPriya
{
    class Matrix
    {

        public static int[,] Add(int[,] a,int[,] b)
        {
            int firstrowlength = a.GetLength(0);
            int firstcoloumnlength = a.GetLength(1);
            int secondrowlength = b.GetLength(0);
            int secondcolumnlength = b.GetLength(1);
            int[,] resultArray = new int[firstrowlength, firstcoloumnlength];
            if ((firstrowlength == secondrowlength) && (firstcoloumnlength == secondcolumnlength))
            {
                //int[,] resultArray = new int[firstrowlength, firstcoloumnlength];
                for (int i = 0; i < firstcoloumnlength; i++)
                {
                    for (int j = 0; j < firstcoloumnlength; j++)
                    {
                        resultArray[i, j] = a[i, j] + b[i, j];
                    }
                }
                return resultArray;
            }
            else
            {
                Console.WriteLine("Arrays must be of equal size");
                return null;
            }

            
        }

        public static int[,] Multiply(int[,] a, int[,] b)
        {
            int row = a.GetLength(0); // a of m*n and b of n*m, then product array will be m*m
            int column=b.GetLength(1); // row length from 1st and column length from 2
            int[,] resultArray = new int[row, column];
            if (a.GetLength(1) == b.GetLength(0))
            {
                int commonindex = a.GetLength(1); // or b.getlength(0);
               
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {

                        resultArray[i, j] = 0;
                        for (int k = 0; k < commonindex; k++)
                        {
                            resultArray[i, j] += (a[i, k]*b[k, j]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Matrix multiplication is not possible");
            }
            return resultArray;
        }
    }
}
