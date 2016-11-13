using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class UniqueCharactersTest
    {
        internal static void Run()
        {
            string inputString = "Test String";
            Console.WriteLine("Given input is: {0}\nDoes it have unique Characters?: {1}\n\n", inputString, UniqueCharacters.Algorithm(inputString));

            inputString = "Fox Tail";
            Console.WriteLine("Given input is: {0}\nDoes it have unique Characters?: {1}\n\n", inputString, UniqueCharacters.Algorithm(inputString));

            inputString = "Fox          Tail";
            Console.WriteLine("Given input is: {0}\nDoes it have unique Characters?: {1}\n\n", inputString, UniqueCharacters.Algorithm(inputString));

            inputString = "Fox Tail try";
            Console.WriteLine("Given input is: {0}\nDoes it have unique Characters?: {1}\n\n", inputString, UniqueCharacters.Algorithm(inputString));
        }
    }
}
