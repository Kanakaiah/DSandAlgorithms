using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK
{
    internal class MatrixArithmetic
    {
        internal static double[,] Add(double[,] a, double[,] b)
        {
            double[,] output = new double[4, 4];

            int rowLength = a.GetLength(0);
            int columnLength = a.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    output[i, j] = a[i, j] + b[i, j];

                }

            }

            return output;
        }

        internal static double[,] Subtract(double[,] a, double[,] b)
        {
            double[,] output = new double[4, 4];

            int rowLength = a.GetLength(0);
            int columnLength = a.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    output[i, j] = a[i, j] + b[i, j];

                }

            }

            return output;
        }


        internal static double[,] Mutliplication(double[,] a, double[,] b)
        {
            double[,] output = new double[4, 4];

            int rowLength = a.GetLength(0);
            int columnLength = a.GetLength(1);
            double temp = 0;


            for (int r = 0; r < rowLength; r++)
            {
                for (int c1 = 0; c1 < columnLength; c1++)
                {

                    for (int c = 0; c < columnLength; c++)
                    {
                        temp += a[r, c] * b[c, c1];
                    }

                    output[r, c1] = temp;
                    temp = 0;
                }
            }
            return output;
        }
    }

    internal class MatrixArithmeticTest
    {

        internal static void Run()
        {
            double[,] a = new double[4, 4]{ {1,2,3,4},
                                            {5,6,7,8},
                                            {9,10,11,12},
                                            {13,14,15,16}};

            double[,] b = new double[4, 4]{ {1,2,3,4},
                                            {5,6,7,8},
                                            {9,10,11,12},
                                            {13,14,15,16}};

            //double[,] output= MatrixArithmetic.Add(a, b);
            double[,] output = MatrixArithmetic.Mutliplication(a, b);

            for (int i = 0; i < output.GetLength(0); i++)
            {
                for (int j = 0; j < output.GetLength(1); j++)
                {
                    Console.Write(output[i, j]);
                    Console.Write("  ");
                }

                Console.WriteLine();

            }

            Console.Read();

        }

    }
}
