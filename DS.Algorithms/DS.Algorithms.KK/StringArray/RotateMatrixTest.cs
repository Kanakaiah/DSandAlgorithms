using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class RotateMatrixTest
    {

        public static void Run()
        {

            string[,] matrix = new string[4, 4] { { "A", "B", "C", "D" }, { "E", "F", "G", "H" }, { "I", "J", "K", "L" }, { "M", "N", "O", "P" } };

            Console.WriteLine("---------Input---------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();

            }

            var matrixout = RotateMatrix.Rotate90(matrix);

            Console.WriteLine("---------Output---------");

            for (int i = 0; i < matrixout.GetLength(0); i++)
            {
                for (int j = 0; j < matrixout.GetLength(1); j++)
                {
                    Console.Write(matrixout[i, j] + " ");
                }

                Console.WriteLine();

            }

            //input 2

            matrix = new string[5, 5] { { "A", "B", "C", "D","E" }, { "F", "G", "H", "I", "J" }, { "K", "L", "M", "N", "O" }, { "P", "Q", "R", "S", "T" }, { "U" ,"V","W","X","Y"} };

            Console.WriteLine("---------Input---------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();

            }

            matrixout = RotateMatrix.Rotate90(matrix);
            Console.WriteLine("---------Output---------");

            for (int i = 0; i < matrixout.GetLength(0); i++)
            {
                for (int j = 0; j < matrixout.GetLength(1); j++)
                {
                    Console.Write(matrixout[i, j] + " ");
                }

                Console.WriteLine();

            }

        }
    }
}
