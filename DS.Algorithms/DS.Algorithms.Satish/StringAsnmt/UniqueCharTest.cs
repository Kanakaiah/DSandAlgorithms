using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class UniqueCharTest
    {
        internal static void Run()
        {
            string input = "abc def g";

            Console.WriteLine("String : " + input  + UniqueChar.DisplayUnique(UniqueChar.IsUnique(input)));

            input = "abcdefga";

            Console.WriteLine("String : " + input + UniqueChar.DisplayUnique(UniqueChar.IsUnique(input)));

            input = "abcdefghijklmnopqrstuvwxyz";

         //   Console.WriteLine("String : " + input + (UniqueChar.isUniqueChars(input)));

            input = "abcdefghijklmnopqrstuvwx yz";

            Console.WriteLine("String : " + input + UniqueChar.DisplayUnique(UniqueChar.isUniqueChar(input)));

            UniqueChar.printBytes();
        }

        
    }
}
