using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class UniqueCharacters
    {

        /// <summary>
        /// An algorithm to determine if a string has all unique characters - Method1
        /// The time complexity for this code is 0(n), where n is the length of the string. 
        /// The space complexity is 0(1).
        /// </summary>
        /// <param name="str">input string assuming to have ASCII</param>
        /// <returns></returns>
        public static bool Method1(string str)
        {
            //Checking for a null or an empty string
            if (string.IsNullOrEmpty(str))
                throw new Exception("String can not be an empty or null string");

            //After all, you can't have a string with 280 unique characters if there are only 256 possible unique characters
            if (str.Length > 256) return false;

            //
            bool[] _charset = new bool[256];

            foreach (var charval in str.ToCharArray())
            {
                if (charval > 255)
                    throw new Exception("Characters are out of the bound(256 range)!");
                if (_charset[charval])
                    return false;
                else
                    _charset[charval] = true;
            }

            return true;
        }


        /// <summary>
        /// An algorithm to determine if a string has all unique characters - Method 2
        /// The time complexity for this code is 0(n), where n is the length of the string. 
        /// No space complexity - hence we are using bit wise operation
        /// </summary>
        /// <param name="str">input string assuming to have ASCII</param>
        /// <returns></returns>
        public static bool Method2(string str)
        {
            //Checking for a null or an empty string
            if (string.IsNullOrEmpty(str))
                throw new Exception("String can not be an empty or null string");

            //After all, you can't have a string with 280 unique characters if there are only 256 possible unique characters
            if (str.Length > 256) return false;

            //
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';

                //Console.WriteLine("{0}-{1}", checker, Convert.ToString(checker, 2));
                //Console.WriteLine("{0}-{1}", val, Convert.ToString(val, 2));
                //Console.WriteLine("{0}-{1}", 1 << val, Convert.ToString(1 << val, 2));
                //Console.WriteLine("{0}-{1}", checker & (1 << val), Convert.ToString(checker & (1 << val), 2));
                //Console.WriteLine("{0}-{1}", checker |= (1 << val), Convert.ToString(checker |= (1 << val), 2));

                if ((checker & (1 << val)) > 0) return false;
                checker |= (1 << val);
            }
            return true;

        }

    }


    public class UniqueCharactersTest
    {

        //public static void Run()
        //{
        //    var inputStr = "Jesus so loved the World!";
        //    Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method1(inputStr));


        //    inputStr = "abcdefgh!";
        //    Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method1(inputStr));


        //    inputStr = "abcdefgha!";
        //    Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method1(inputStr));


        //    inputStr = "!abcdefgh!";
        //    Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method1(inputStr));


        //    //Negative test cases

        //    inputStr = null;
        //    Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method1(inputStr));


        //    //inputStr = "ឈញដ";
        //    //Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method1(inputStr));


        //    inputStr = "అఆఇఈఉఊఋఌఎఏఐఒఓఔ";
        //    Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method1(inputStr));

        //}


        public static void Run()
        {
            var inputStr = "jesus so loved the world!";
            Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method2(inputStr));


            inputStr = "abcd efgh";
            Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method2(inputStr));


            inputStr = "abcdefgha";
            Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method2(inputStr));


            inputStr = "!abcdefgh";
            Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method2(inputStr));


            inputStr = "abcdefgh IJKLMNU opqrst UVWXYZ";
            Console.WriteLine("input: {0}  >>> Output: {1}", inputStr, UniqueCharacters.Method2(inputStr));

        }
    }
}
