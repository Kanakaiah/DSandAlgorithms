using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class ReverseStringByWordTest
    {
        internal static void Run()
        {
            string input = "Hello         World!";
            Console.WriteLine("Given String is {0}\nReverse string by Word is {1}", input, ReverseStringByWord.Algorithm(input));

            input = "   This is Data Structures (*&(*^%&^%&^^*&&^* #@$@$#@$";
            Console.WriteLine("Given String is {0}\nReverse string by Word is {1}", input, ReverseStringByWord.Algorithm(input));

            input = "!@#$%^^&**((   (*&^%%";
            Console.WriteLine("Given String is {0}\nReverse string by Word is {1}", input, ReverseStringByWord.Algorithm(input));
        }
    }
}
