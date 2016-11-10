using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
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
