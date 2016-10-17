using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK
{
    internal class ReveseTheNumber
    {

        internal static int Process(int theNumber)
        {
            int outputNumber = 0;

            while((theNumber/10)!=0)
            {

                outputNumber = outputNumber*10 + (theNumber % 10);

                theNumber = theNumber/10;
            }

            return outputNumber*10 + theNumber;
        }
    }
}
