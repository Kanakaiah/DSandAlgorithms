using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Bhanu.Exercises
{
    public class MatrixBased
    {
        public static void Test_MatrixRotation()
        {
            int[,] m = new int[,]
                        { { 1, 2, 3, 4 },
                            { 5, 6, 7, 8 },
                            { 9,10,11,12},
                            { 13,14,15,16} };

            int[,] m1 = new int[,]
                         { { 1, 2, 3},
                            { 5, 6, 7},
                            { 9,10,11},
                         };

            //MatrixRotationApproach1(m);
            //MatrixRotationApproach1(m1);

            MatrixRotationApproach2(m);
            MatrixRotationApproach2(m1);
        }

        private static void MatrixRotationApproach1(int[,] m)
        {
            int size = m.GetLength(0);
            int numOfLoops = size / 2;

            for (int i = 0; i < numOfLoops; i++)
            {
                RotateLoop(m, i, size);
            }
        }

        private static void MatrixRotationApproach2(int[,] m)
        {
            //Skew matrix
            Skewmatrix(m);

            //reverse along y axis.
            ReverseAlongColumns(m);
        }

        private static void Skewmatrix(int[,] m)
        {
            int size = m.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    int temp = m[i, j];
                    m[i, j] = m[j, i];
                    m[j, i] = temp;
                }
            }
        }

        private static void ReverseAlongColumns(int[,] m)
        {
            int size = m.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size / 2; j++)
                {
                    int k = size - j - 1;
                    int temp = m[i, k];
                    m[i, k] = m[i, j];
                    m[i, j] = temp;
                }
            }
        }

        private void Swap()
        { }
        private static void RotateLoop(int[,] m, int loopIndex, int size)
        {
            int subMatrixSize = size - 2 * loopIndex;

            int i = loopIndex, j = loopIndex;

            // num of groups of numbers (1, 4, 16..), (2, 8, 15), (3, 12, 14)
            for (int c = 1; c <= subMatrixSize - 1; c++)
            {
                int prevValue = m[i, j];
                for (int k = 0; k < 4; k++)
                {
                    // (for index (i,j) get the position after rotation. 
                    int temp = i;
                    i = j;
                    j = size - temp - 1;

                    int temp_prev = prevValue;
                    prevValue = m[i, j];
                    m[i, j] = temp_prev;
                }
                j++;
            }
        }

        public static void Test_MakeEntireRowAndColumnZeros()
        {
            int[,] m = new int[,]
                          { { 1,0, 3, 4 },
                            { 5, 6, 7, 8 },
                            { 9,10,0,12}};

            int[,] m1 = new int[,]
                         { {0, 2, 3},
                            { 5, 6, 7},
                            { 7,10,0},
                         };

            MakeEntireRowAndColumnZerosApproach2(m);
            MakeEntireRowAndColumnZerosApproach2(m1);
        }

        private  static void MakeEntireRowAndColumnZeros(int[,] m)
        {
            int numRows = m.GetLength(0);
            int numcols = m.GetLength(1);

            int oddManoutNumber = -1; //asuming all the numbers are positive

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numcols; j++)
                {
                    if (m[i, j] == 0)
                    {
                        for (int k = 0; k < numcols; k++)
                        {
                            m[i, k] = oddManoutNumber;
                        }

                        for (int k = 0; k < numRows; k++)
                        {
                            m[k, j] = oddManoutNumber;
                        }

                        break;
                    }
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numcols; j++)
                {
                    if (m[i, j] == oddManoutNumber)
                    {
                        m[i, j] = 0;
                    }
                }
            }
        }

        private static void MakeEntireRowAndColumnZerosApproach2(int[,] m)
        {
            int numRows = m.GetLength(0);
            int numcols = m.GetLength(1);

            bool[] rowsWithZero = new bool[numRows];
            bool[] colsWithZero = new bool[numcols];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numcols; j++)
                {
                    if (m[i, j] == 0)
                    {
                        rowsWithZero[i] = true;
                        colsWithZero[j] = true;
                    }
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                bool entireRow = rowsWithZero[i];

                for (int j = 0; j < numcols; j++)
                {
                    if (entireRow || colsWithZero[j])
                    {
                        m[i, j] = 0;
                    }
                }
            }
        }
    }
}