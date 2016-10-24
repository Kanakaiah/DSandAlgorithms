using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Bhanu
{
    public class StringProblems
    {
        public static void Test_PalindromeChecking()
        {
            string[] ar = new string[] { "", "BAAB","MADAM", "A", "DEAR", "MADABADAM" };

            foreach (string s in ar)
            {
                Console.WriteLine(s + ":" + CheckIfPalindrome(s));
            }
        }

        public static void Test_PalindromeCheckingSpecialcase()
        {
            string[] ar = new string[] { "#", "#B$AAB", "#%!B$AAB", "MADAM", "A#", "DEAR", "%%%MADAB##ADAM!$^" };

            foreach (string s in ar)
            {
                Console.WriteLine(s + ":" + CheckIfPalindromeSpecialCase(s));
            }
        }

        private static  bool CheckIfPalindrome(string inputStr)
        {
            var length = inputStr.Length;

            for(int i =0; i < (length + 1) /2  ; i++)
            {
                if(inputStr[i] != inputStr[length -i -1])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckIfPalindromeSpecialCase(string inputStr)
        {
            var length = inputStr.Length;
            var start = 0;
            var end = length - 1;

            while (start < end)
            {
                if (!IsAlphaNumericCharacter(inputStr[start]))
                {
                    start++;
                    continue;
                }

                if(!IsAlphaNumericCharacter(inputStr[end]))
                {
                    end--;
                    continue;
                }

                if (inputStr[start++] != inputStr[end--])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsAlphaNumericCharacter(char ch)
        {
            return ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) ? true : false;
        }
    }
}
