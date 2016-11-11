using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class ReplaceWithSpace
    {
        /// <summary>
        /// Write a method to replace all spaces in a string with '%20'. You may assume that the
        /// string has sufficient space at the end of the string to hold the additional characters,
        /// and that you are given the "true" length of the string. (Note: if implementing in Java,
        /// please use a character array so that you can perform this operation in place.)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Replace(string str)
        {
            char[] chrArray = str.ToCharArray();

            char[] tempArray = str.ToCharArray();
            int counter = 0;
            string temp=string.Empty;
            for (int i = 0; i < chrArray.Length; i++)
            {
                if(chrArray[i]==' ')
                {
                    
                    chrArray[i] = '%';
                    chrArray[i + 1] = '2';
                    chrArray[i + 2] = '0';
                    for (int j = i+3,k=(i+1)-(2*counter); j < (tempArray.Length); k++,j++)
                    {
                        chrArray[j] = tempArray[k];
                    }
                    i += 2;
                    counter++;
                }
                
            }

            return new string(chrArray);
        }
    }

    public class ReplaceWithSpaceTest
    {
        public static void Run()
        {
            var str = "Jesus is the Lord      ";
            Console.WriteLine("Input: '{0}' --->Output: {1} ", str, ReplaceWithSpace.Replace(str));


            str = " Jesus is the Lord        ";
            Console.WriteLine("Input: '{0}' --->Output: {1} ", str, ReplaceWithSpace.Replace(str));


            str = " Jesus is the Lord           ";
            Console.WriteLine("Input: '{0}' --->Output: {1} ", str, ReplaceWithSpace.Replace(str));



            str = " Jesus  is the Lord             ";
            Console.WriteLine("Input: '{0}' --->Output: {1} ", str, ReplaceWithSpace.Replace(str));

        }
    }
}
