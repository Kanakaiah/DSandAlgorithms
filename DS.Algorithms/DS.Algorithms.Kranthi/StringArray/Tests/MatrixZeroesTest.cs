using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class MatrixZeroesTest
    {
        internal static void Run()
        {
            int[,] matrix = new int[,] { { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 0 } };
            Console.WriteLine("Input:");
            MatrixZeroes.PrintMatrix(matrix);
            MatrixZeroes.Algorithm(matrix);
            Console.WriteLine();
            Console.WriteLine("Output:");
            MatrixZeroes.PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine();
            matrix = new int[,] { { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 0 }, { 0, 0, 1, 1, 0 }, { 0, 0, 1, 1, 0 }, { 0, 0, 1, 1, 0 } };
            Console.WriteLine("Input:");
            MatrixZeroes.PrintMatrix(matrix);
            MatrixZeroes.Algorithm(matrix);
            Console.WriteLine();
            Console.WriteLine("Output:");
            MatrixZeroes.PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine();
            matrix = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Console.WriteLine("Input:");
            MatrixZeroes.PrintMatrix(matrix);
            MatrixZeroes.Algorithm(matrix);
            Console.WriteLine();
            Console.WriteLine("Output:");
            MatrixZeroes.PrintMatrix(matrix);
        }
    }
}
