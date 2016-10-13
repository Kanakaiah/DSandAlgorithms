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
}
