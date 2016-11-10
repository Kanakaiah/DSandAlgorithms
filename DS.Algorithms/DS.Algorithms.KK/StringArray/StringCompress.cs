using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class StringCompress
    {

        public static string Compress(string str)
        {
            string compressed = string.Empty;
            char current = str[0];
            int count = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == current)
                {
                    count++;
                }
                else
                {
                    compressed = compressed + current + count.ToString();
                    count = 1;
                    current = str[i];
                }

            }

            compressed = compressed + current + count.ToString();

            return compressed.Length < str.Length ? compressed : str;

        }
    }
}
