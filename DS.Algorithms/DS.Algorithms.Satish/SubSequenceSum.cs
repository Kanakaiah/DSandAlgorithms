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
        public int intialSeq;
        public int maxSeqSum;

        public void displayArray()
        {
            for (int i = 0; i < seq.Length ; i++)
            {
                Console.WriteLine("Element at :(" + i + ") : " + seq[i]);

            }
            Console.WriteLine();
           
        }

        public void displaySubSum()
        {
            intialSeq = 0;
            maxSeqSum = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                intialSeq = intialSeq + seq[i];
                if ( intialSeq > 0)
                {
                    maxSeqSum = intialSeq;// + seq[i];
                }
                else
                {
                    intialSeq = 0;
                }
            }

            Console.WriteLine("Sub Sum :" + maxSeqSum);


           // return maxSeqSum;
        }
       
    }
}
