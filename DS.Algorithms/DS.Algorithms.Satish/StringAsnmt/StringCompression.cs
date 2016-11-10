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
            if (inStr.Length <= 2)
                return inStr;

            if (inStr == null)
                return null; 

           // string compStr = null ;
            int strCnt = 1;
            char c = ' ';
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inStr.Length - 1; i++)
            {
                c = inStr[i];
                if(c == inStr[i + 1])
                {
                    strCnt++;
                }else
                {
                  //  compStr = compStr + c + strCnt;
                    sb.Append(c);
                    sb.Append(strCnt);
                    strCnt = 1;
                }
            }
           // compStr = compStr + c + strCnt;
            sb.Append(c);
            sb.Append(strCnt);

            if (inStr.Length <= sb.Length)
                return inStr;
            else
                return sb.ToString();//compStr;
        }
    }
}
