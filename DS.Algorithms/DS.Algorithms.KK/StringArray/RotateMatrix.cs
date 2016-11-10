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
}
