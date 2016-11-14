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

    internal class ReveseTheNumberTest
    {
        internal static void Run()
        {

            int input = 1234;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = -1234;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = 123400;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = 1307130571;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = -1307130571;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = 0;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = -1;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = -100;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));
            input = 100001;
            Console.WriteLine("{0}-----> {1}", input, ReveseTheNumber.Process(input));

            Console.Read();

        }
    }
}
