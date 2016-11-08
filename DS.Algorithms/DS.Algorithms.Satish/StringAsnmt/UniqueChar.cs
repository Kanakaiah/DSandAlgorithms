using System;
using System.Collections;
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
            inStr = inStr.ToLower();
            // If the string is more than 26 Chars then It is not Unique, there is no need to check for all characters
            if(inStr.Length > 26)
            {
                return false;
            }
            char uniqueChar;
            for (int i = 0; i < inStr.Length; i++)
            {
                uniqueChar = Convert.ToChar(inStr[i]);
                if (uniqueChar == ' ')
                    continue;
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

        public static int isUniqueChars(String str)
        {
            if (str.Length > 26)
            { // NOTE: Are you sure this isn't 26?
                return 1;
            }
            int checker = 0;
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                int val1 = 1 << val;
                Console.WriteLine("Char : "+ str[i] + " " + val1 +" " + val);
                if ((checker & (1 << val)) > 0)
                {
                    return val;
                }
                else
                {
                    checker |= (1 << val);
                    Console.WriteLine();
                    Console.WriteLine("Checker :" + (checker));
                    Console.WriteLine();
                }
                    
            }
            return checker;
        }

        //Efficient way of checking if the string has unique chars using bit operations
        public static bool isUniqueChar(String str)
        {
            str = str.ToLower();
            if (str.Length > 256)
            { // NOTE: Are you sure this isn't 26?
                return false;
            }
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0) return false;
                checker |= (1 << val);
            }
            return true;
        }

        //Method to Print Bits of an Integer
        public static void printBytes()
        {
            int num = 1;
            int check = 0;
            num = num << 3;
            BitArray b = new BitArray(new int[] { num });
            BitArray c = new BitArray(new int[] { check });
            
            bool[] bits = new bool[b.Count];
            bool[] bits1 = new bool[c.Count];
            b.CopyTo(bits,0);
            c.CopyTo(bits1, 0); // Copying the bits of 0
            Console.WriteLine();
            Console.WriteLine("Bytes of the number : " + num);
            Console.WriteLine();
            //foreach (bool bo in bits)
            //{
            //    Console.Write(bo);
            //}

            byte[] bitValues = bits.Select(bit => (byte)(bit ? 1 : 0)).ToArray();

            foreach (byte bo in bitValues.Reverse())
            {
                Console.Write(bo + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Bytes of the number : " + check);
            Console.WriteLine();
            //foreach (bool bo in bits)
            //{
            //    Console.Write(bo);
            //}

            byte[] bitValues1 = bits1.Select(bit => (byte)(bit ? 1 : 0)).ToArray();

            foreach (byte bo in bitValues1.Reverse())
            {
                Console.Write(bo + " ");
            }
            Console.WriteLine();

            check |= num << 3;

            BitArray d = new BitArray(new int[] { check });
            bool[] bits2 = new bool[d.Count];
            d.CopyTo(bits2, 0);

            byte[] bitValues2 = bits2.Select(bit => (byte)(bit ? 1 : 0)).ToArray();

            foreach (byte bo in bitValues2.Reverse())
            {
                Console.Write(bo + " ");
            }
            Console.WriteLine();
        }

    }
}
