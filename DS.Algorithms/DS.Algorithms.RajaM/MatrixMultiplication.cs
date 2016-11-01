using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.RajaM
{
    public class MatrixMultiplication : IRun
    {

        private int[,] _firstMatrix;

        private int[,] _secondMatrix;

        private int[,] _resultMatrix;

        private int _dimensionOfSquareMatrix;

        public MatrixMultiplication() {

            _dimensionOfSquareMatrix = 4;

            _firstMatrix = new int[,]
        {
            {2,2,2,2},
            {3,3,3,3},
            {4,4,4,4},
            {5,5,5,5}
        };
            _secondMatrix = new int[,]
        {
            {6,7,8,9},
            {6,7,8,9},
            {6,7,8,9},
            {6,7,8,9}
        };

            _resultMatrix = new int[_dimensionOfSquareMatrix, _dimensionOfSquareMatrix];

        }

        public void Run() {
            DoMatrixMultiplication(_firstMatrix, _secondMatrix, 4);

            Console.WriteLine("First Matrix for multiplication:");
            Console.WriteLine();
            PrintMatrix(_firstMatrix);
            Console.WriteLine();

            Console.WriteLine("Second Matrix for multiplication:");
            Console.WriteLine();
            PrintMatrix(_secondMatrix);
            Console.WriteLine();

            Console.WriteLine("Result Matrix result are multiplication of first and second Matrix:");
            Console.WriteLine();
            PrintMatrix(_resultMatrix);
            Console.WriteLine();
        }

        //public void CollectInformationForMatrixMultiplication() {
            //Console.Write("Please enter dimention size of the squre matix you want to multiply:");
            //int matrixSize = Int32.Parse(Console.ReadLine());
        //}

        public void DoMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int dimensionOfSquareMatrix) {

            // since this a square rectangle the width and height dimensions of the matrix are the same
            for (int row = 0; row < dimensionOfSquareMatrix; row++)
            {
                for (int column = 0; column < dimensionOfSquareMatrix; column++)
                {
                    _resultMatrix[row, column] = GetMatrixMultipiationResult(firstMatrix, secondMatrix, row, column, dimensionOfSquareMatrix);
                }
            }
        }

        private int GetMatrixMultipiationResult(int[,] firstMatrix, int[,] secondMatrix, int row, int column, int dimensionOfSquareMatrix) {
            int result = 0;

            for (int i = 0; i < dimensionOfSquareMatrix; i++)
            {
                result = result + (firstMatrix[row,i] * secondMatrix[i,column]);
            }

            return result;
        }

        private void PrintMatrix(int[,] matrix) {

            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                StringBuilder matrixRow = new StringBuilder();
                matrixRow.Append("     ");
                for (int j = 0; j < column; j++)
                {
                    matrixRow.Append(matrix[i, j].ToString() + ", ");
                }
                matrixRow.Remove(matrixRow.Length - 2, 2);

                Console.WriteLine(matrixRow);
            }
        }
    }
}
