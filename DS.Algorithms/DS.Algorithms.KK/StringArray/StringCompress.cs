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

    /// <summary>
    /// Implement a method to perform basic string compression using the counts of
    ///repeated characters.For example, the string aabcccccaaa would become
    ////a2blc5a3.If the "compressed" string would not become smaller than the original
    ////string, your method should return the original string
    /// </summary>
    public class StringCompressTest
    {

        public static void Run()
        {
            var str = "compressed";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaaa";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaa";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccaaa";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaaaffff";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaaahhhhh";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaaannnnnnnnn";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaaamnopq";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaaamnopqqqqqqqq";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));

            str = "aabcccccaaamnopqqqqqqqqnmjjjjjjjjjjjjj";
            Console.WriteLine("input string:  {0} ----> Compressed String:  {1}", str, StringCompress.Compress(str));
        }

    }
}
