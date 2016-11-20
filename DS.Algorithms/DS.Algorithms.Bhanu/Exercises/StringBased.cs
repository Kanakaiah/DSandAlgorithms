using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Bhanu.Exercises
{
    public class StringBased
    {
        /// <summary>
        /// 1. Sort the chars
        /// 2. check if any two consecutive characters are same.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckIfAllCharsAreUniqueApproach1(string s)
        {
            char[] chars = s.ToCharArray();
            Sort(chars);
            char prev = chars[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (chars[i] == prev)
                {
                    return false;
                }

                prev = chars[i];
            }

            return true;
        }

        private static void Sort(char[] s)
        {
            //quick sort or merge sort
        }

        /// <summary>
        /// 1. Maintain array of bools indicating presence of particular character 
        /// 2. loop through each character, check if the current one is already true, in the array.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckIfAllCharsAreUniqueApproach2(string s)
        {
            bool[] charsPresense = new bool[65536];

            for (int i = 0; i < s.Length; i++)
            {
                Int16 unicodeValue = (Int16)s[i];
                if (!charsPresense[unicodeValue])
                {
                    charsPresense[unicodeValue] = true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 1. Push the unicode character  into Hashset (similar to dictionary) if the character is not already present.
        /// 2. Loop through the characters, check if the current character is already present in the hash set.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckIfAllCharsAreUniqueApproach3(string s)
        {
            HashSet<int> dictionary = new HashSet<int>();

            for (int i = 0; i < s.Length; i++)
            {
                Int16 unicodeValue = (Int16)s[i];
                if (!dictionary.Contains(unicodeValue))
                {
                    dictionary.Add(unicodeValue);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 1. Create an aray to main number of occurances of chars of str1.
        /// 2. initialize a variable to track the remaining number of chars(of str1) yet to be found str2.
        /// 3. Loop thru chars of str2, if the that char is not present in array (i.e. not present in str1), return false.
        ///     else  decrement the count of char, and also yettobefoundcount.
        /// 4. if the yetToBeFound count is > 0, there are some chars of str1 missing in str2.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool CheckIfStringsAreAnagramsApproach1(string s1, string s2)
        {
            char[] charsCounts = new char[26];

            if (s1.Length != s2.Length)
            {
                return false;
            }

            //chars counts of first string
            for (int i = 0; i < s1.Length; i++)
            {
                char ch = ToLower(s1[i]);
                charsCounts[ch - 'a']++;
            }

            //number of chars yet to see in second string
            int charsYetTosee = s1.Length;

            for (int i = 0; i < s2.Length; i++)
            {
                //get lower case letter.
                char ch = ToLower(s2[i]);

                // some character is obeserved in 2nd string which was present '0' number of times in s1.
                if (charsCounts[ch - 'a'] == 0)
                {
                    return false;
                }
                else
                {
                    charsCounts[ch - 'a']--;
                    charsYetTosee--;
                }
            }

            if (charsYetTosee > 0)
            {
                return false;
            }

            return true;
        }

        public static bool CheckIfStringsAreAnagramsApproach1Optimized(string s1, string s2)
        {
            char[] charsCounts = new char[26];

            if (s1.Length != s2.Length)
            {
                return false;
            }

            //chars counts of first string
            for (int i = 0; i < s1.Length; i++)
            {
                char ch = ToLower(s1[i]);
                charsCounts[ch - 'a']++;
            }

            //number of chars yet to see in second string
            int charsYetTosee = s1.Length;

            for (int i = 0; i < s2.Length; i++)
            {
                //get lower case letter.
                char ch = ToLower(s2[i]);

                // some character is obeserved in 2nd string which was present '0' number of times in s1.
                if (charsCounts[ch - 'a'] == 0)
                {
                    return false;
                }
                else
                {
                    charsCounts[ch - 'a']--;
                    charsYetTosee--;
                }
            }

            if (charsYetTosee > 0)
            {
                return false;
            }

            return true;
        }

        private static char ToLower(char ch)
        {
            //logic to convert to lower.
            return ch;
        }

        public static void Test_ReplaceSpacesWithAPattern()
        {
            string s = "Sky is red and blue        ";
            var ar = s.ToCharArray();
            ReplaceSpacesWithAPattern(ar, 19);
        }
        /// <summary>
        /// Replace a space with %20. 
        /// Assumptions:
        /// The inputstring has extra space exactly suffient to accomodate the string aftre replacement of ' '.
        /// Approach:
        /// Loop through from end of string (valid end pos) to beginning, and copy the characters to the 
        /// end position (i.e. position with extra spaces). if space ('') is found copy '%20'.
        /// 
        /// Stretch: If the input string has extra space more than needed, in first pass number of spaces have to be counted to calculate 
        /// exact endpoisition.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="actualLength"></param>
        private static void ReplaceSpacesWithAPattern(char[] s, int actualLength)
        {
            int endPos = s.Length - 1;
            for (int i = actualLength - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    s[endPos--] = s[i];
                }
                else
                {
                    s[endPos--] = '0';
                    s[endPos--] = '2';
                    s[endPos--] = '%';
                }
            }
        }

        public static void Test_StringCompression()
        {
            string[] ar = new string[] { "aabbccdddeefff", "abcde", "abcdeeeeeeeeffffffffffffggg", "a", "bb", "ab" };

            foreach (string s in ar)
            {
                var sout = CompressString(s);
                Console.WriteLine("{0}  ---> {1}", s, sout);
            }
        }

        private static string CompressString(string s)
        {
            StringBuilder sb = new StringBuilder();

            if (s.Length <= 2)
            {
                return s;
            }

            char prev = s[0];
            int i = 1;
            int subSeriesCount = 1;
            while (i < s.Length)
            {
                if (s[i] == prev)
                {
                    subSeriesCount++;
                }
                else
                {
                    sb.Append(prev);
                    sb.Append(subSeriesCount);
                    prev = s[i];
                    subSeriesCount = 1;
                }

                i++;
            }

            sb.Append(prev);
            sb.Append(subSeriesCount);

            string sout = sb.ToString();

            if (sout.Length >= s.Length)
            {
                return s;
            }
            else
            {
                return sout;
            }
        }

        public static void Test_checkIfOneIsRotationOfAnother()
        {
            string[,] inputs = new string[,]
            {
                { "WaterBottle", "eWaterBottle"},
                { "WaterBottle", "aterBottleW"},
                { "WaterBottle", "eWatexBottle"},
                { "WaterBottle", "eWaterBottld"},
            };

            for (int i = 0; i < inputs.GetLength(0); i++)
            {
                Console.WriteLine("{0}, {1} :", inputs[i, 0], inputs[i, 1]);
                Console.Write(checkIfOneIsRotationOfAnother(inputs[i, 0], inputs[i, 1]));
                Console.WriteLine();
            }
        }

        private static bool checkIfOneIsRotationOfAnother(string s1, string s2)
        {
            int i = 0;
            int j = 0;

            while (i < s2.Length)
            {
                j = 0;
                while (j < s1.Length && i < s2.Length && s1[j] == s2[i])
                {
                    j++;
                    i++;
                }

                i++;
            }

            if (j == 0)
            {
                return false;
            }

            int temp = j;

            i = 0;
            while (i < s2.Length)
            {
                j = temp;
                while (j < s1.Length && i < s2.Length && s1[j] == s2[i])
                {
                    j++;
                    i++;
                }

                i++;
            }

            if (j != s1.Length)
            {
                return false;
            }

            return true;
        }
    }
}