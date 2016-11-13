using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringCompressTest
    {
        internal static void Run()
        {
            string input = "aabcccccaaa";
            Console.WriteLine("\nInput String -> "+ input + "\n" + StringCompression.Compress(input));

            input = "abcd";
            Console.WriteLine("\nInput String -> " + input + "\n" + StringCompression.Compress(input));

            input = "aabcccccaaaddddddeeeeefererggggg";
            Console.WriteLine("\nInput String -> " + input + "\n" + StringCompression.Compress(input));
        }
    }
}
