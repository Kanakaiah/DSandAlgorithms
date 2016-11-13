using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class ReplaceSpacesTest
    {
        internal static void Run()
        {
            string inputString = "a b  c      ";
            Console.WriteLine("Input:{0}\nOutput:{1}\n", inputString, ReplaceSpaces.Algorithm(inputString));

            inputString = " a b c      ";
            Console.WriteLine("Input:{0}\nOutput:{1}\n", inputString, ReplaceSpaces.Algorithm(inputString));

            inputString = "abc";
            Console.WriteLine("Input:{0}\nOutput:{1}\n", inputString, ReplaceSpaces.Algorithm(inputString));

            inputString = "abc   ";
            Console.WriteLine("Input:{0}\nOutput:{1}\n", inputString, ReplaceSpaces.Algorithm(inputString));
        }
    }
}
