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

    internal class PalindromeTest
    {
        internal static void Run()
        {

            string str = "Was it a car or a cat I saw ?";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "A man, a plan, a canal, Panama!?";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "Was it a pcar or a cat I saw ?";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "A man, a plan, a cmanal, Panama!?";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "Iam";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "Am I a King?";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "Madam";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);
            str = "  Ma ad da a m";
            Console.WriteLine(Palindrome.IsTrue(str) ? "{0}-----> It's a palindrome" : "{0}-----> It's not a palindrome", str);

            Console.Read();

        }
    }
}
