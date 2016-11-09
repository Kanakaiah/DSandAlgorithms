using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringAnagramTest
    {
        internal static void Run()
        {
            string s1 = "listen";
            string s2 = "silent";
            Console.WriteLine("Are these Strings  Anagrams : " + StringAnagram.isAnagram(s1, s2));
            s1 = "sathish";
            s2 = "anusha";
            Console.WriteLine("Are these Strings  Anagrams : " + StringAnagram.isAnagram(s1, s2));

            s1 = "sathisht";
            s2 = "sannidhi";
            Console.WriteLine("Are these Strings  Anagrams : " + StringAnagram.isAnagram(s1, s2));

            s1 = "debit card";
            s2 = "bad credit";
            Console.WriteLine("Are these Strings  Anagrams : " + StringAnagram.isAnagram(s1, s2));
            s1 = "Astronomer";
            s2 = "Moon starrer";
            Console.WriteLine("Are these Strings  Anagrams : " + StringAnagram.isAnagram(s1, s2));
            
        }
    }
}
