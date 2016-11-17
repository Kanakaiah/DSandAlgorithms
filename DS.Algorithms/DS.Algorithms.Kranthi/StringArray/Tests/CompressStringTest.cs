using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class CompressStringTest
    {
        internal static void Run()
        {
            string inputString = "aabbccdddff";
            Console.WriteLine("Input is {0}, Compressed String is {1}", inputString, CompressString.Algorithm(inputString));

            inputString = "aa";
            Console.WriteLine("Input is {0}, Compressed String is {1}", inputString, CompressString.Algorithm(inputString));

            inputString = "abcdef";
            Console.WriteLine("Input is {0}, Compressed String is {1}", inputString, CompressString.Algorithm(inputString));

            inputString = "aabbccdddfg";
            Console.WriteLine("Input is {0}, Compressed String is {1}", inputString, CompressString.Algorithm(inputString));

            inputString = "aaaaaaaaaaaaa               ";
            Console.WriteLine("Input is {0}, Compressed String is {1}", inputString, CompressString.Algorithm(inputString));
        }
    }
}
