using System;

namespace DS.Algorithms.Kranthi.StringArray
{
    class NumberTest
    {
        internal static void Run()
        {

            long input = 1234;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = -1234;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = 123400;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = 1307130571;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = -1307130571;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = 0;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = -1;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = -100;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));
            input = 100001;
            Console.WriteLine("{0}-----> {1}", input, Number.Reverse(input));

            Console.Read();

        }
    }
}
