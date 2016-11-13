using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK
{
    internal class MaximumSubsequences
    {
        internal static int Sum(int[] input,out int startIndex,out int lastIndex)
        {
            int SeqMaxSum = 0;
            int SeqMaxSumTemp = 0;
            int length = input.Length;
            startIndex = 0;
            lastIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {

                while (length > 1)
                {
                    for (int j = i; j < length; j++)
                    {
                        SeqMaxSumTemp += input[j];
                    }

                    if (SeqMaxSumTemp > SeqMaxSum)
                    {
                        SeqMaxSum = SeqMaxSumTemp;
                        startIndex = i;
                        lastIndex = length-1;

                            }

                    SeqMaxSumTemp = 0;
                    length--;
                }
                length = input.Length;
            }

            
            return SeqMaxSum;
        }


        internal static int Multiplication(int[] input, out int startIndex, out int lastIndex)
        {
            int SeqMaxSum = 1;
            int SeqMaxSumTemp = 1;
            int length = input.Length;
            startIndex = 0;
            lastIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {

                while (length > 1)
                {
                    for (int j = i; j < length; j++)
                    {
                        SeqMaxSumTemp *= input[j];
                    }

                    if (SeqMaxSumTemp > SeqMaxSum)
                    {
                        SeqMaxSum = SeqMaxSumTemp;
                        startIndex = i;
                        lastIndex = length - 1;

                    }

                    SeqMaxSumTemp = 1;
                    length--;
                }
                length = input.Length;
            }


            return SeqMaxSum;
        }
    }

    internal class MaximumSubsequencesTest
    {

        internal static void RunSum()
        {

            int startIndex, lastInex;

            int[] input = new int[] { 1, 2, 3, 4 };
            string inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Sum(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 1, -2, 3, 4, 5, 6, -7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Sum(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 2, 4, -5, 3, 7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Sum(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 1, 3, -2, 4, 5, 6, -7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Sum(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 2, 14, -5, 3, 15, -1, 7, -10, 2, 10, -15 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Sum(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { -15, 10, 2, -10, 7, -1, 15, 3, -5, 14, 2 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Sum(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            Console.Read();
        }


        internal static void RunMultiplication()
        {

            int startIndex, lastInex;

            int[] input = new int[] { 1, 2, 3, 4 };
            string inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Multiplication(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 1, -2, 3, 4, 5, 6, -7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Multiplication(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 2, 4, -5, 3, 7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Multiplication(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 1, 3, -2, 4, 5, 6, -7 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Multiplication(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { 2, 14, -5, 3, 15, -1, 7, -10, 2, 10, -15 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Multiplication(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            input = new int[] { -15, 10, 2, -10, 7, -1, 15, 3, -5, 14, 2 };
            inputStr = String.Join(",", new List<int>(input).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(inputStr);
            Console.WriteLine("Maximum Sum:{0} from Index {1} to {2}", MaximumSubsequences.Multiplication(input, out startIndex, out lastInex), startIndex, lastInex);
            Console.WriteLine();

            Console.Read();
        }

    }
}
