using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray
{
    class CompressString
    {
        /// <summary>
        /// Compresses the given input string. 
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <returns>Original string, if the compressed string is greater than original string
        /// Compressed String, Otherwise</returns>
        internal static string Algorithm(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException("Input String is Null");

            if (inputString == string.Empty)
                return string.Empty;

            //String Builder initialized with first character of the input string
            StringBuilder compressedString = new StringBuilder(inputString[0].ToString());

            int counter = 1;
            for (int index = 1; index < inputString.Length; index++)
            {
                counter = 1;
                while (inputString[index] == inputString[index - 1])
                {
                    index++;
                    counter++;
                    if (index > inputString.Length - 1)
                        break;
                }
                compressedString.Append(counter);

                //index value may become equal to length of input string as index is also incremented in while loop
                //Hence handling the condition here
                if (index < inputString.Length)
                {
                    compressedString.Append(inputString[index]);
                }
            }

            return (compressedString.Length < inputString.Length) ? compressedString.ToString() : inputString;
        }
    }
}
