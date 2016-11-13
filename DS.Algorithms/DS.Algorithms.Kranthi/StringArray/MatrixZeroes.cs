using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class MatrixZeroes
    {
        /// <summary>
        /// Prints Matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        internal static void PrintMatrix(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            long columnLength = matrix.GetLength(1);
            for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                {
                    Console.Write("{0} ", matrix[rowIndex, columnIndex]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// If a value is 0 in a matrix, Sets all rows and columns to 0
        /// </summary>
        /// <param name="matrix">Matrix</param>
        internal static void Algorithm(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            long columnLength = matrix.GetLength(1);
            int[] rows = new int[rowLength];
            int[] columns = new int[columnLength];
            
            for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                {
                    if (matrix[rowIndex, columnIndex] == 0)
                    {
                        rows[rowIndex] = 1;
                        columns[columnIndex] = 1;
                    }
                }
            }

            for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                {
                    if (rows[rowIndex] == 1 || columns[columnIndex] == 1)
                    {
                        matrix[rowIndex, columnIndex] = 0;
                    }
                }
            }
        }
    }
}
