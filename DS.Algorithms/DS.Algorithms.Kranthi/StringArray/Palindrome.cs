namespace DS.Algorithms.Kranthi.StringArray
{
    class Palindrome
    {
        /// <summary>
        /// This method checks if a given string is a Palindrome or not.
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns>True, if the string is Palindrome
        /// False, Otherwise</returns>
        internal static bool IsTrue(string inputString)
        {
            return string.IsNullOrEmpty(inputString) ? false : PalindromeAlgo(inputString);
        }

        /// <summary>
        /// Palindrome Algorithm
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns>True, if the string is Palindrome
        /// False, Otherwise</returns>
        private static bool PalindromeAlgo(string inputString)
        {
            inputString = inputString.ToLowerInvariant();
            int reverseIndex = inputString.Length - 1;
            for (var index = 0; index <= reverseIndex; index++, reverseIndex--)
            {
                if (!char.IsLetter(inputString[index]))
                {
                    reverseIndex++;
                    continue;
                }

                if(!char.IsLetter(inputString[reverseIndex]))
                {
                    index--;
                    continue;
                }
                
                if (inputString[index] != inputString[reverseIndex])
                    return false;
            }

            return true;
        }
    }
}
