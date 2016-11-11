using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{

    /// <summary>
    /// 10. Given an image represented by an NxN matrix, where each pixel in the image is 4
    /// bytes, write a method to rotate the image by 90 degrees.Can you do this in place?
    /// </summary>
    public class RotateMatrix
    {
        public static string[,] Rotate90(string[,] matrix)
        {
            int length;
            string temp = string.Empty;

              length = matrix.GetLength(1)-1;

            int top = 0, bottom = matrix.GetLength(1) - 1;

            int left = 0, right = matrix.GetLength(1) - 1;


            while (top<bottom)
            {

                for (int j = top,i=bottom,k=right; j < length; j++,i--,k--)
                {
             
                    // right to temp
                    temp = matrix[j, right];
                    //top to right
                    matrix[j,right] = matrix[top, j];
                    //left to top
                    matrix[top, j] = matrix[i, top];
                    //bottom to left
                    matrix[i, top] = matrix[bottom, k];
                    //right to bottom
                    matrix[bottom, k] = temp;

                }

                length -= 1;
                top++;
                bottom--;
                right--;
                left++;
            }

            return matrix;

        }
    }

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

            matrix = new string[5, 5] { { "A", "B", "C", "D", "E" }, { "F", "G", "H", "I", "J" }, { "K", "L", "M", "N", "O" }, { "P", "Q", "R", "S", "T" }, { "U", "V", "W", "X", "Y" } };

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


            //input 3

            matrix = new string[3, 3] { { "A", "B", "C" }, { "D", "E", "F" }, { "G", "H", "I" } };

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



            //input 4

            matrix = new string[2, 2] { { "A", "B" }, { "C", "D" } };

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

            //input 5

            matrix = new string[1, 1] { { "A" } };

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

            //input 6
            //input 5

            matrix = new string[10, 10] { {"01","02","03","04","05","06","07","08","09","10"},
                                        {"11","12","13","14","15","16","17","18","19","20"},
                                        {"21","22","23","24","25","26","27","28","29","30"},
                                        {"31","32","33","34","35","36","37","38","39","40"},
                                        {"41","42","43","44","45","46","47","48","49","50"},
                                        {"51","52","53","54","55","56","57","58","59","60"},
                                        {"61","62","63","64","65","66","67","68","69","70"},
                                        {"71","72","73","74","75","76","77","78","79","80"},
                                        {"81","82","83","84","85","86","87","88","89","90"},
                                        {"91","92","93","94","95","96","97","98","99","100"} };

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
