using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    /// <summary>
    /// Matrix Rotation BY 90 Degrees.
    /// </summary>
    class MatrixRotation
    {
        public static void RotateBy90(char[,] inputMat)
        {
            Console.WriteLine();
            Console.WriteLine("Input Matrix");
            Console.WriteLine();
            for (int i = 0; i < inputMat.GetLength(0); i++)
            {
                for (int j = 0; j < inputMat.GetLength(1); j++)
                {
                    Console.Write(inputMat[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Output Matrix after rotating By 90 Degrees");
            Console.WriteLine();
            for (int i = 0; i < inputMat.GetLength(0); i ++)
            {
                for (int j = inputMat.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(inputMat[j,i]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
