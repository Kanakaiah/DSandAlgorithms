using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class MatrixRotateTest
    {
        internal static void Run()
        {
            char[,] matrix = {
                              { 'A','B','C','D'},
                              { 'E','F','G','H'},
                              { 'I','J','K','L'},
                              { 'M','N','O','P'}
                             };
            Console.WriteLine();
            Console.WriteLine("Matrix Rotation BY 90 Degrees");
            Console.WriteLine();
            MatrixRotation.RotateBy90(matrix);
        }
    }
}
