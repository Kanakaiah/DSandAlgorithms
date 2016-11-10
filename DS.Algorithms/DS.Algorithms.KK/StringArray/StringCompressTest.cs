using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
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
