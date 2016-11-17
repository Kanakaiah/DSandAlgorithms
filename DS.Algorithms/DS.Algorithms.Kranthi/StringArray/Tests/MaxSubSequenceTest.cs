using System;
using System.Collections.Generic;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class MaxSubSequenceTest
    {
        internal static void RunSum()
        {
            int startIndex, lastIndex;

            int[] input = new int[] { 1, 2, 3, 4 };
            string inputStr = string.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaxSubSequence.Sum(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 1, -2, 3, 4, 5, 6, -7 };
            inputStr = string.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaxSubSequence.Sum(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 2, 4, -5, 3, 7 };
            inputStr = string.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaxSubSequence.Sum(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 1, 3, -2, 4, 5, 6, -7 };
            inputStr = string.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaxSubSequence.Sum(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 2, 14, -5, 3, 15, -1, 7, -10, 2, 10, -15 };
            inputStr = string.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaxSubSequence.Sum(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { -15, 10, 2, -10, 7, -1, 15, 3, -5, 14, 2 };
            inputStr = string.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaxSubSequence.Sum(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            Console.Read();
        }

        internal static void RunProduct()
        {
            int startIndex, lastIndex;

            int[] input = new int[] { 1, 2, 3, 4 };
            string inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Product:{0} from Index {1} to {2}", MaxSubSequence.Product(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 1, -2, 3, 4, 5, 6, -7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Product:{0} from Index {1} to {2}", MaxSubSequence.Product(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 2, 4, -5, 3, 7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Product:{0} from Index {1} to {2}", MaxSubSequence.Product(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 1, 3, -2, 4, 5, 6, -7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Product:{0} from Index {1} to {2}", MaxSubSequence.Product(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();

            input = new int[] { 2, 14, -5, 3, 15, -1, 7, -10, 2, 10, -15 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Product:{0} from Index {1} to {2}", MaxSubSequence.Product(input, out startIndex, out lastIndex), startIndex, lastIndex);
            Console.WriteLine();
           
            Console.Read();
        }
    }
}
