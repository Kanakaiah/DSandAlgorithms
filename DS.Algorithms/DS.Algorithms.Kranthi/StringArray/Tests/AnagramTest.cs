using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class AnagramTest
    {
        internal static void Run()
        {
            string string1 = "listen";
            string string2 = "enlist";

            Console.WriteLine("{0} and {1} are anagrams of each other?: {2}", string1, string2, Anagram.IsTrue(string1, string2));

            string1 = "Listen";
            string2 = "Enlist";

            Console.WriteLine("{0} and {1} are anagrams of each other?: {2}", string1, string2, Anagram.IsTrue(string1, string2));

            string1 = "listen";
            string2 = "list";

            Console.WriteLine("{0} and {1} are anagrams of each other?: {2}", string1, string2, Anagram.IsTrue(string1, string2));

            string1 = "listen           ";
            string2 = "list        en";

            Console.WriteLine("{0} and {1} are anagrams of each other?: {2}", string1, string2, Anagram.IsTrue(string1, string2));
        }
    }
}
