using System;

namespace DS.Algorithms.Kranthi.StringArray
{
    class ArrayArithmetic
    {
        /// <summary>
        /// Adds two Arrays
        /// </summary>
        /// <param name="firstArray">First Array</param>
        /// <param name="secondArray">Second Array</param>
        /// <returns>Resultant of Added Arrays</returns>
        internal static long[,] Add(long[,] firstArray, long[,] secondArray)
        {
            int rowLength = firstArray.GetLength(0);
            long columnLength = firstArray.GetLength(1);
            if (rowLength.Equals(secondArray.GetLength(0)) || columnLength.Equals(secondArray.GetLength(1)))
            {
                long[,] resultantArray = new long[rowLength, columnLength];

                for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                    {
                        resultantArray[rowIndex, columnIndex] = firstArray[rowIndex, columnIndex] + secondArray[rowIndex, columnIndex];
                    }
                }
                return resultantArray;
            }
            else
            {
                Console.WriteLine("Array Addition is not Possible");
                Console.WriteLine("Number of Rows/Columns in First Array do not match with the number of Rows/Columns in Second Array");
                return null;
            }
        }

        /// <summary>
        /// Substracts two Arrays
        /// </summary>
        /// <param name="firstArray">First Array</param>
        /// <param name="secondArray">Second Array</param>
        /// <returns>Resultant of Substracted Arrays</returns>
        internal static long[,] Substract(long[,] firstArray, long[,] secondArray)
        {
            int rowLength = firstArray.GetLength(0);
            long columnLength = firstArray.GetLength(1);
            if (rowLength.Equals(secondArray.GetLength(0)) || columnLength.Equals(secondArray.GetLength(1)))
            {
                long[,] resultantArray = new long[rowLength, columnLength];

                for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                    {
                        resultantArray[rowIndex, columnIndex] = firstArray[rowIndex, columnIndex] - secondArray[rowIndex, columnIndex];
                    }
                }
                return resultantArray;
            }
            else
            {
                Console.WriteLine("Array Substraction is not Possible");
                Console.WriteLine("Number of Rows/Columns in First Array do not match with the number of Rows/Columns in Second Array");
                return null;
            }
        }

        /// <summary>
        /// Multiplies two Arrays
        /// </summary>
        /// <param name="firstArray">First Array</param>
        /// <param name="secondArray">Second Array</param>
        /// <returns>Resultant of Multiplied Arrays</returns>
        internal static long[,] Multiply(long[,] firstArray, long[,] secondArray)
        {
            int anotherLength = firstArray.GetLength(1);
            if (anotherLength.Equals(secondArray.GetLength(0)))
            {
                int rowLength = firstArray.GetLength(0);
                int columnLength = secondArray.GetLength(1);
                long[,] resultantArray = new long[rowLength, columnLength];

                for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                    {
                        resultantArray[rowIndex, columnIndex] = 0;
                        for (int anotherIndex = 0; anotherIndex < anotherLength; anotherIndex++)
                        {
                            resultantArray[rowIndex, columnIndex] += firstArray[rowIndex, anotherIndex] * secondArray[anotherIndex, columnIndex];
                        }
                    }
                }
                return resultantArray;
            }
            else
            {
                Console.WriteLine("Array Multiplication is not Possible");
                Console.WriteLine("Number of Columns in First Array do not match with the number of Rows in Second Array");
                return null;
            }
        }        
    }
}
