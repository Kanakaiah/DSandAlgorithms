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
}
