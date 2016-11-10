using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringCompression
    {
        public static string Compress(string inStr)
        {
            string compStr = null ;
            int strCnt = 1;
            char c=' ';
            for (int i = 0; i < inStr.Length - 1; i++)
            {
                c = inStr[i];
                if(c == inStr[i + 1])
                {
                    strCnt++;
                }else
                {
                    compStr = compStr + c + strCnt;
                    strCnt = 1;
                }
            }
            compStr = compStr + c + strCnt;

            if (inStr.Length <= compStr.Length)
               return inStr;
            else
                return compStr;
        }
    }
}
