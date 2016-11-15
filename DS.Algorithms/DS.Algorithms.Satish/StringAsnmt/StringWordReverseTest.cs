using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringWordReverseTest
    {
        internal static void Run()
        {
            string input = "sky is blue today";
            Console.WriteLine("String Word Reverse Demo ");
            Console.WriteLine();
            Console.WriteLine("Input String -> " + input);
            Console.WriteLine();
            Console.WriteLine("Out Put");
            Console.WriteLine();
            Console.WriteLine(StringWordReverse.Reverse(input));
        }
    }
}
