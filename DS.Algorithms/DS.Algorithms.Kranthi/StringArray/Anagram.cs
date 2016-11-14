using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class Anagram
    {
        /// <summary>
        /// This method checks if a given string is an Anagaram of the other.
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <param name="anotherString">Another String</param>
        /// <returns>True, if one string is anagram of other
        /// False, Otherwise</returns>
        /*internal static bool IsTrue(string inputString, string anotherString)
        {
            if (inputString.Length != anotherString.Length)
                return false;

            inputString = SortString(inputString);

            anotherString = SortString(anotherString);

            for (int index = 0; index < inputString.Length; index++)
            {
                if (inputString[index] != anotherString[index])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Sorts the given strings
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns>Sorted String</returns>
        private static string SortString(string inputString)
        {
            char[] characters = inputString.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }*/

        /// <summary>
        /// This method checks if a given string is an Anagaram of the other.
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <param name="anotherString">Another String</param>
        /// <returns>True, if one string is anagram of other
        /// False, Otherwise</returns>
        internal static bool IsTrue(string inputString, string anotherString)
        {
            if (inputString.Length != anotherString.Length)
                return false;

            const int CHARACTER_LENGTH = 256;
            int[] characters = new int[CHARACTER_LENGTH];

            for (int index = 0; index < inputString.Length; index++)
            {
                if (inputString[index] > 255 || anotherString[index] > 255)
                    throw new Exception("This method supports only ASCII or UNICODE Strings");

                characters[inputString[index]]++;
                characters[anotherString[index]]--;
            }
            for (int index = 0; index < CHARACTER_LENGTH; index++)
            {
                if (characters[index] != 0)
                    return false;
            }
            return true;
        }
    }
}
