using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class UniqueCharacters
    {
        /// <summary>
        /// Checks if string has unique characters
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns>True, if string has unique characters
        /// False, Otherwise</returns>
        /*internal static bool Algorithm(string inputString)
        {
            const int MAX_CHARACTERS = 256;
            bool[] characters = new bool[MAX_CHARACTERS];

            if (inputString.Length > MAX_CHARACTERS)
                return false;
            
            for (int index = 0; index < inputString.Length; index++)
            {
                if (inputString[index] > 255)
                    throw new Exception("This method supports only ASCII or UNICODE Strings");

                if (characters[inputString[index]])
                    return false;

                characters[inputString[index]] = true;
            }
            return true;
        }*/

        /// <summary>
        /// Checks if string has unique characters
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns>True, if string has unique characters
        /// False, Otherwise</returns>
        internal static bool Algorithm(string inputString)
        {
            const char CHARACTER_A = 'a';
            int checker = 0;
            for (int index = 0; index < inputString.Length; index++)
            {
                int value = inputString[index] - CHARACTER_A;
                
                if ((checker & (1 << value)) > 0)
                    return false;

                checker |= (1 << value);
            }
            return true;
        }
    }
}
