using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish
{
    public class SubSequenceSum
    {
        public int[] seq = new int[7] { 2, 4, -6, 8, 9, -3, 5 };
        public static int intialSeq;
        public static int maxSeqSum;

        public static void displayArray(int[] inputArray)
        {
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < inputArray.Length ; i++)
            {
                Console.Write( inputArray[i] + ",");

            }
            Console.WriteLine();
           
        }

        public static int displaySubSum(int[] inputArray)
        {
            displayArray(inputArray);

            intialSeq = 0;
            maxSeqSum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                intialSeq = intialSeq + inputArray[i];
                if ( intialSeq > 0 )
                {
                    if (intialSeq > maxSeqSum)
                    {
                        maxSeqSum = intialSeq;// + seq[i];
                    }

                   
                }
                else
                {
                    intialSeq = 0;
                }
            }

          //  Console.WriteLine("Sub Sum :" + maxSeqSum);


            return maxSeqSum;
        }
       
    }
}
