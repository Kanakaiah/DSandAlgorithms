using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class Anagram
    {
        /// <summary>
        /// Given two strings, write a method to decide if one is a permutation(or anagram) of the other.
        //Example: The word "silent" is an anagram of "listen".
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool IsAnagramString1(string s1, string s2)
        {

            if (s1.Length != s2.Length)
                return false;

            int counter = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if(s1[i]==s2[j])
                    {
                        counter++;
                        if (j == 0)
                            s2 = s2.Substring(1);
                        else if(j== s2.Length-1)
                        {
                            s2 = s2.Substring(0, j);

                        }
                        else
                            s2 = s2.Substring(0, j) + s2.Substring(j + 1);
                        break;
                    }

                }

                if (counter > 0)
                {
                    counter = 0;
                    continue;
                }
                else return false;

            }
            return true;

        }
    }

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


