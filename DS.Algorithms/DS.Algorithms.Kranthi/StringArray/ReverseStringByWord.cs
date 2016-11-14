using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class ReverseStringByWord
    {
        internal static string Algorithm(string inputString)
        {
            string reverseString = "";
            string [] words = ReverseString(inputString).Split(' ');
            foreach (var word in words)
            {
                reverseString += ReverseString(word);
                reverseString += " ";
            }
            return reverseString;
        }

        private static string ReverseString(string inputString)
        {
            if (inputString == null)
                return null;

            if (inputString.Length == 1)
                return inputString;

            string reverseString = "";
            for (int index = inputString.Length - 1; index >= 0; index--)
            {
                reverseString += inputString[index];
            }
            return reverseString;
        }
    }
}
