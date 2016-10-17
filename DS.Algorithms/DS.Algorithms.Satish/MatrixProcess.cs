using System;

namespace DS.Algorithms.Satish
{
    class MatrixProcess
    {
        int[,] matrixA = new int[3, 3] 
        { { 2,3,5 },
          { 3,5,8 },
          { 4,5,7 }
        };

        int[,] matrixB = new int[3, 3]
        {
            {3,6,9 },
            {7,9,1 },
            {8,2,1 }
        };

      //  int[,] matrixProduct = new int[3, 3];
      public void product()
        {
            calculateProduct(matrixA, matrixB);
        }

      void calculateProduct(int[,] matA, int[,] matB)
        {
            int sum = 0;
            int[,] matrixProduct = new int[3, 3];
            Console.WriteLine("In the Matrix Product!");
            Console.WriteLine("The First length of the Array :" + matA.GetLength(0));
            Console.WriteLine("The Second length of the Array :" + matA.GetLength(1));
            //Loop through the first matrix rows
            for (int i = 0; i < matA.GetLength(0); i++)
            {
                //Loop through the first Matrix Column numbers
                for (int j = 0; j < matA.GetLength(1); j++)
                {
                    //Loop through the second matrix rows
                    for (int k = 0; k < matB.GetLength(0); k++)
                    {
                       // Console.Write(" " + matA[i, j] + " " + matB[j, i]);
                        sum = sum + matA[i, k] * matB[k, j];
                    }
                    matrixProduct[i, j] = sum;
                    sum = 0;
                }
            }
            //return matrixProduct;

            for (int m = 0; m < matrixProduct.GetLength(0); m++)
            {
                for (int n = 0; n < matrixProduct.GetLength(1); n++)
                {
                    Console.Write(matrixProduct[m, n] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
