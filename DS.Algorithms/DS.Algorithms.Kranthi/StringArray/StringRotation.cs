using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class StringRotation
    {
        internal static bool IsTrue(string inputString, string rotatedString)
        {
            if (inputString == null || rotatedString == null)
                throw new ArgumentNullException("Input String is Null");

            if (inputString.Length != rotatedString.Length)
                return false;
            
            inputString = inputString + inputString;
            int anotherIndex = 0;
            for (int index = 0; index < inputString.Length && anotherIndex < rotatedString.Length; index++)
            {
                if (inputString[index] == rotatedString[anotherIndex])
                {
                    anotherIndex++;
                }
                else
                {
                    anotherIndex = 0;
                }
            }

            if (anotherIndex == rotatedString.Length)
                return true;

            return false;
        }
    }
}
