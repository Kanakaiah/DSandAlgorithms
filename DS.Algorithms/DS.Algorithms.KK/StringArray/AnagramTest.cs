using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class AnagramTest
    {
        public static void Run()
        {
            //test anagram strings
            var s1 = "silent";
            var s2 = "listen";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));


            s1 = "THE EYES";
            s2 = "THEY SEE";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));

            s1 = "abc";
            s2 = "def";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));

            s1 = "abed";
            s2 = "bade";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));


            s1 = "actors";
            s2 = "costar";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));


            s1 = "allergy";
            s2 = "gallery";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));


            s1 = "cratered";
            s2 = "retraced";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));


            s1 = "restrain";
            s2 = "retrains";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));

            s1 = "resort";
            s2 = "roster";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));

            s1 = "realize";
            s2 = "realizm";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));

            s1 = "modern";
            s2 = "odernm";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));


            s1 = "globalized";
            s2 = "globagized";
            Console.WriteLine("s1: {0}   s2:{1}   IsAnagram:{2}", s1, s2, Anagram.IsAnagramString1(s1, s2));

        }


    }
}
