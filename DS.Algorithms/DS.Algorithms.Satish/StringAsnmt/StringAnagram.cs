using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringAnagram
    {
        public static bool isAnagram(string str1, string str2)
        {
            bool isFound = true;
            //str1 = str1.ToLower();
           // str2 = str2.ToLower();
            //Check if the 2 string lengths are equal if not the are not anagram
            if (str1.Length != str2.Length)
            {
                return false;
            }else
            {
                //Start checking if the strings are Anagrams
                foreach(char c in str1.ToCharArray())
                {
                    // if (c == ' ')
                    //    continue;
                    if (!isFound)
                        return false;
                    // isFound = false;
                    foreach(char d in str2.ToCharArray())
                    {
                        
                        if (c == d) {
                            isFound = true;
                            break;
                        }else
                        {
                            isFound = false;
                          //  return isFound;
                        }
                    }
                }
            }


            return isFound;
        }

        public static bool isAnagramByCount(string str1, string str2)
        {

            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                int str1Count = 0;
                int str2Count = 0;
                for (int i = 0; i < str1.Length; i++)
                {
                    str1Count += str1[i];
                    str2Count += str2[i];
                }
            //    Console.WriteLine(str1Count + " " + str2Count);
                if (str1Count != str2Count)
                {
                    return false;
                }
                else
                    return true;
            }
                

        }
    }
}
