using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
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
