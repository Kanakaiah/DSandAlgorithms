using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    public class MatrixZeroRowColumn
    {
        public static void MakeRowColumn(int[,] inputMat)
        {
           //Copying the elements into another Array
            int[,] output = inputMat.Clone() as int[,];
           
            Console.WriteLine();
            Console.WriteLine("Makig Row and Column Zero if an Element is Zero");
            Console.WriteLine();
            Console.WriteLine("Input Matrix");
            Console.WriteLine();
            for (int i = 0; i < inputMat.GetLength(0); i++)
            {
                for(int j = 0; j < inputMat.GetLength(1); j++)
                {
                    Console.Write(output[i, j]);
                    Console.Write(' ');
                    //if (j == jBreak)
                    //    continue;

                    if (inputMat[i, j] == 0 && output[i,j] == 0)
                    {
                        for (int k = 0; k < inputMat.GetLength(1); k++)
                        {
                            inputMat[i, k] = 0;
                            inputMat[k, j] = 0;
                        }
                        //jBreak = j;
                      //  break;
                    }
                   // else
                     //   output[i, j] = inputMat[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Output  Matrix");
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

        }
    }
}
