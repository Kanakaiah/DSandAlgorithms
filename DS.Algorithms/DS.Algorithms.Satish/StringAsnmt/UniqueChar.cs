using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    /// <summary>
    /// This Class is to Find a Unique character in the Given String
    /// <param name = "inStr">inStr</param>
    /// Return Type is Boolean
    /// </summary>
    public class UniqueChar
    {
        public static bool IsUnique(string inStr)
        {
            char uniqueChar;
            for (int i = 0; i < inStr.Length; i++)
            {
                uniqueChar = Convert.ToChar(inStr[i]);
                for (int j = i + 1; j < inStr.Length; j++)
                {
                    if (uniqueChar == Convert.ToChar(inStr[j]))
                        {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string DisplayUnique(bool yesOrNo)
        {
            if(yesOrNo == true)
            {
                return " Has Unique Characters";
            }
            else
            {
                return " Doesn't have Unique Characters";
            }
        }
    }
}
