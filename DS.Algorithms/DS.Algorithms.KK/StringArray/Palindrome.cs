using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK
{
    internal class Palindrome
    {
        internal static bool IsTrue(string inputStr)
        {

            //1. Check for empty string
            return string.IsNullOrEmpty(inputStr) ? false : PalindromeAlg(inputStr);

        }

        static bool PalindromeAlg(string inputStr)
        {

            int n = inputStr.Length - 1;

            for (int i = 0; i!=n; i++)
            {
                if (char.IsLetter(inputStr[i]))
                {
                    if (char.IsLetter(inputStr[n]))
                    {

                        if (char.ToUpperInvariant(inputStr[i]) == char.ToUpperInvariant(inputStr[n]))
                        {
                            n--;
                            continue;
                        }
                        else
                            return false;

                    }
                    else
                    {
                        i--;
                        n--;
                    }

                }
                else
                    continue;
            }

            return true;
        }
    }
}
