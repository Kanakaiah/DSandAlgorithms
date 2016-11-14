using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringRotation
    {
        public static string CheckRotation(string inStr1, string inStr2)
        {
            char firstChar;
            char lastChar;
            string rotatedString = null;
            int index;
            if (inStr1.Length != inStr2.Length)
                return "Its not a Rotated String";
            else
            {
                inStr1 = inStr1.ToLower();
                inStr2 = inStr2.ToLower();

                firstChar = inStr1[0];
                lastChar = inStr1[inStr1.Length - 1];
                index = inStr2.IndexOf(firstChar);
                int lastIndex;
                if (index == 0)
                    lastIndex = inStr2.Length - 1;
                else
                    lastIndex = index - 1;

                if(lastChar == inStr2[lastIndex])
                {
                    
                    for (int i = index; i < inStr2.Length; i++)
                    {
                        rotatedString = rotatedString + inStr2[i];

                    }
                    for(int j = 0; j < index; j++)
                    {
                        rotatedString = rotatedString + inStr2[j];
                    }
                   
                }

            }

            return "First Char "+ firstChar + index + rotatedString;
        }
    }
}
