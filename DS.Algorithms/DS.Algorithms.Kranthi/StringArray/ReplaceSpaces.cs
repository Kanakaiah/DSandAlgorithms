using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class ReplaceSpaces
    {
        /// <summary>
        /// Replaces White Space with %20 in a given string
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns></returns>
        /*internal static string Algorithm(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException("Input string is null");

            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < inputString.Length; index++)
            {
                if (inputString[index] == ' ')
                {
                    stringBuilder.Append("%20");
                }
                else
                {
                    stringBuilder.Append(inputString[index]);
                }
            }
            return stringBuilder.ToString();
        }*/

        /// <summary>
        /// Replaces White Space with %20 in a given string
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns></returns>
        internal static string Algorithm(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException("Input string is null");

            int counter = 0;
            char[] characters = inputString.ToCharArray();
            char[] temporaryCharacters = inputString.ToCharArray();
            for (int index = 0; index < inputString.Length; index++)
            {
                if (characters[index] == ' ')
                {
                    characters[index] = '%';
                    characters[index + 1] = '2';
                    characters[index + 2] = '0';
                    int newIndex = index + 3;
                    int tempIndex = (index + 1) - (counter * 2);
                                    
                    while (newIndex < temporaryCharacters.Length)
                    {
                        characters[newIndex++] = temporaryCharacters[tempIndex++];
                    }
                    counter++;
                    index += 2;                    
                }
            }
            return new string(characters);
        }
    }
}
