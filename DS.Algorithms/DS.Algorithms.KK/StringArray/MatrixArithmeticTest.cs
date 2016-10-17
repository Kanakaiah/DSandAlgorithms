using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
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
           double[,] output= MatrixArithmetic.Mutliplication(a, b);

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

