using System;

namespace DS.Algorithms.Kranthi.StringArray
{
    class ArrayArithmeticTest
    {
        internal static void Run()
        {
            long[,] a = new long[4, 4]{ {1,2,3, 4},
                                            {5,6,7, 8},
                                            {9,10,11, 12},
                                            {13,14,15, 16}};

            long[,] b = new long[4, 4]{ {1,2,3,4},
                                            {5,6,7,8},
                                            {9,10,11, 12},
                                            {13,14,15, 16}};

            PrintArray(ArrayArithmetic.Add(a, b));
            PrintArray(ArrayArithmetic.Substract(a, b));
            PrintArray(ArrayArithmetic.Multiply(a, b));

            a = new long[4, 3]{ {1,2,3},
                                            {5,6,7},
                                            {9,10,11},
                                            {13,14,15}};

            b = new long[3, 4]{ {1,2,3,4},
                                            {5,6,7,8},
                                            {9,10,11,12}};

            PrintArray(ArrayArithmetic.Add(a, b));
            PrintArray(ArrayArithmetic.Substract(a, b));
            PrintArray(ArrayArithmetic.Multiply(a, b));

            a = new long[3, 4]{ {1,2,3, 4},
                                            {5,6,7, 8},
                                            {9,10,11, 12}};

            b = new long[3, 4]{ {1,2,3,4},
                                            {5,6,7,8},
                                            {9,10,11,12}};

            PrintArray(ArrayArithmetic.Add(a, b));
            PrintArray(ArrayArithmetic.Substract(a, b));
            PrintArray(ArrayArithmetic.Multiply(a, b));
            
            Console.Read();

        }

        private static void PrintArray(long[,] output)
        {
            if (output != null)
            {
                for (int i = 0; i < output.GetLength(0); i++)
                {
                    for (int j = 0; j < output.GetLength(1); j++)
                    {
                        Console.Write(output[i, j]);
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
