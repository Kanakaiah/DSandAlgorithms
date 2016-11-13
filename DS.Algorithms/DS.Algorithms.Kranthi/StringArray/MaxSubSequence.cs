using System;

namespace DS.Algorithms.Kranthi.StringArray
{
    class MaxSubSequence
    {
        /// <summary>
        /// This method calculates maximum subsequence sum of given numbers
        /// </summary>
        /// <param name="numbers">input numbers</param>
        /// <param name="startIndex">Start Index of the maximum subsequence sum</param>
        /// <param name="lastIndex">Last Index of the maximum subsequence sum</param>
        /// <returns>Maximum Subsequence Sum</returns>
        internal static int Sum(int[] numbers, out int startIndex, out int lastIndex)
        {
            int maxSubSum = numbers[0];
            int subSum = numbers[0];
            startIndex = 0;
            lastIndex = 0;
            int tempIndex = 0;

            if (numbers == null)
                throw new ArgumentNullException("Array is Null");

            if (numbers.Length == 1)
                return numbers[0];

            for (int index = 1; index < numbers.Length; index++)
            {                
                if (subSum < 0)
                {
                    tempIndex = index;
                    subSum = 0;
                }
                subSum += numbers[index];

                if (subSum > maxSubSum)
                {
                    maxSubSum = subSum;
                    startIndex = tempIndex;
                    lastIndex = index;
                }
            }

            return maxSubSum;
        }

        /// <summary>
        /// Finds minimum of given two numbers
        /// </summary>
        /// <param name="number1">Number 1</param>
        /// <param name="number2">Number 2</param>
        /// <returns>Minimum of the given numbers</returns>
        private static long Min(long number1, long number2)
        {
            return number1 < number2 ? number1 : number2;
        }

        /// <summary>
        /// Finds maximum of given two numbers
        /// </summary>
        /// <param name="number1">Number 1</param>
        /// <param name="number2">Number 2</param>
        /// <returns>Maximum of the given numbers</returns>
        private static long Max(long number1, long number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        /// <summary>
        /// This method calculates maximum subsequence product of given numbers
        /// </summary>
        /// <param name="numbers">input numbers</param>
        /// <param name="startIndex">Start Index of the maximum subsequence product</param>
        /// <param name="lastIndex">Last Index of the maximum subsequence product</param>
        /// <returns>Maximum Subsequence Product</returns>
        internal static long Product(int[] numbers, out int startIndex, out int lastIndex)
        {
            long maxSubProduct = 1;
            long subProductNegative = 1;
            long subProduct = 1;
            startIndex = 0;
            lastIndex = 0;
            int positiveIndex = -1;
            int negativeIndex = -1;
            int anotherIndex = -1;
            bool toggle = true;
            bool isPositive = false;

            if (numbers == null)
                throw new ArgumentNullException("Array is Null");

            if (numbers.Length == 1)
                return numbers[0];

            for (var index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > 0)
                {
                    positiveIndex = (positiveIndex == -1) ? index : positiveIndex;
                    subProduct *= numbers[index];
                    subProductNegative = Min(subProductNegative * numbers[index], 1);
                    isPositive = true;
                }

                else if (numbers[index] == 0)
                {
                    toggle = true;
                    subProduct = 1;
                    subProductNegative = 1;
                    positiveIndex = -1;
                    negativeIndex = -1;
                    anotherIndex = -1;
                }

                else
                {
                    negativeIndex = (negativeIndex == -1) ? index : negativeIndex;
                    var temp = subProduct;
                    subProduct = Max(subProductNegative * numbers[index], 1);
                    subProductNegative = temp * numbers[index];
                    toggle = !toggle;
                    anotherIndex = index + 1;
                    if(toggle)
                        isPositive = true;
                }

                if (subProduct >= maxSubProduct)
                {
                    maxSubProduct = subProduct;
                    lastIndex = index;
                    if (toggle)
                    {
                        startIndex = Min(positiveIndex, negativeIndex, anotherIndex);
                    }
                    else
                        startIndex = Max(positiveIndex, negativeIndex, anotherIndex);
                }
            }

            if (!isPositive)
                return 0;

            return maxSubProduct;
        }



        /// <summary>
        /// Finds minimum of given two numbers
        /// </summary>
        /// <param name="number1">Number 1</param>
        /// <param name="number2">Number 2</param>
        /// <returns>Minimum of the given numbers</returns>
        private static int Min(int number1, int number2)
        {
            if (number1 == -1)
                number1 = Int32.MaxValue;
            return number1 < number2 ? number1 : number2;
        }

        /// <summary>
        /// Finds minimum of given two numbers
        /// </summary>
        /// <param name="number1">Number 1</param>
        /// <param name="number2">Number 2</param>
        /// <returns>Minimum of the given numbers</returns>
        private static int Max(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        /// <summary>
        /// Finds minimum of given three numbers
        /// </summary>
        /// <param name="number1">Number 1</param>
        /// <param name="number2">Number 2</param>
        /// <param name="number3">Number 3</param>
        /// <returns></returns>
        private static int Max(int number1, int number2, int number3)
        {            
            return Max(Max(number1, number2), number3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns></returns>
        private static int Min(int number1, int number2, int number3)
        {
            return Min(Min(GetMaxNumber(number1), GetMaxNumber(number2)), GetMaxNumber(number3));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int GetMaxNumber(int number)
        {
            return number == -1 ? int.MaxValue : number;
        }
    }
}
