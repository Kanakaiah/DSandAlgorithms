using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DS.Algorithms.Kranthi
{
    class Program
    {
        /// <summary>
        /// Main Method. Entry point of the Program.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructures and Alogirithms!!");
            PrintMenu();
        }

        /// <summary>
        /// This method prints Menu to the User
        /// </summary>
        private static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*\tChoose one from below options\t\t\t\t*");
            Console.WriteLine("*\t1. Reverse a Number\t\t\t\t\t*");
            Console.WriteLine("*\t2. Check if a string is Palindrome\t\t\t*");
            Console.WriteLine("*\t3. Check if a string is Palindrome (Alpha Numeric)\t*");
            Console.WriteLine("*\t9. Exit\t\t\t\t\t\t\t*");
            Console.WriteLine("*****************************************************************");
            var option = Console.ReadKey();

            switch (option.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You chose to reverse a number");
                    Console.WriteLine();
                    Console.Write("Enter any number: ");
                    try
                    {

                        long number = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Reverse of Given Number \"{0}\" is:{1}", number, ReverseNumber(number));
                    
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Input is not a valid number");
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You chose to check if a string is palindrome");
                    Console.WriteLine();
                    Console.Write("Enter any string: ");
                    string inputString = Console.ReadLine();
                    Console.WriteLine("Given String \"{0}\" is {1}", inputString, 
                        IsPalindrome(inputString) ? "a Palindrome" : "not a Palindrome");
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine("You chose to check if string is palindrome which considers AlphaNumeric characters only");
                    Console.WriteLine();
                    Console.Write("Enter any string: ");
                    string alphaNumericString = Console.ReadLine();
                    Console.WriteLine("Given String \"{0}\" is {1}", alphaNumericString,
                        IsPalindrome(alphaNumericString, true) ? "a Palindrome" : "not a Palindrome");
                    break;
                case ConsoleKey.D9:
                    return;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Do you want to perform another operation? (If yes, Press Y)");

            if (!Console.ReadKey().Key.Equals(ConsoleKey.Y))
                return;

            PrintMenu();
        }

        /// <summary>
        /// This method reverses the given number.
        /// It can be a positive or negative number.
        /// </summary>
        /// <param name="number">Input Number</param>
        /// <returns>Reverse of a given number</returns>
        static long ReverseNumber(long number)
        {
            long reverseNumber = 0;
            sbyte signConverter = 1;

            if (number < 0)
            {
                signConverter = -1;
                number *= signConverter;
            }

            while (number > 0)
            {
                reverseNumber = (reverseNumber * 10) + (number % 10);
                number /= 10;
            }
            return reverseNumber * signConverter;
        }

        /// <summary>
        /// This method checks if a given string is a Palindrome or not. 
        /// Palindrome example: A nut for a jar of tuna
        /// Alpha Numeric Palindrome example: A Toyota! Race fast, safe car. A Toyota!
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <param name="alphaNumericOnly"></param>
        /// <returns>True, if the string is Palindrome
        /// False, Otherwise</returns>
        static bool IsPalindrome(string inputString, bool alphaNumericOnly = false)
        {
            if (alphaNumericOnly)
            {
                inputString = RemoveNonAlphaNumeric(inputString);
            }

            inputString = inputString.Replace(" ", "").ToLower();

            var stringLength = inputString.Length;

            for (var index = 0; index < stringLength / 2; index++)
            {
                if (inputString[index] != inputString[stringLength - index - 1])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Removes all non alpha numeric characters from a string
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns>Alpha Numeric String</returns>
        static string RemoveNonAlphaNumeric(string inputString)
        {
            Regex regex = new Regex("[^a-zA-Z0-9 -]");
            return regex.Replace(inputString, "");
        }
    }
}
