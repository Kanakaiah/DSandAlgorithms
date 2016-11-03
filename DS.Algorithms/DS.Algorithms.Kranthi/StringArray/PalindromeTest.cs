using System;

namespace DS.Algorithms.Kranthi.StringArray
{
    class PalindromeTest
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
