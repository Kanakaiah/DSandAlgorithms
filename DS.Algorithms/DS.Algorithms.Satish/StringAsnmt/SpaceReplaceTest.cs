using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    public class SpaceReplaceTest
    {
        internal static void Run()
        {
            string input = "Sathish Testing Spaces";
            Console.WriteLine("\nInput String -> "+ input + "\n" + "Output String -> " +SpaceReplace.Replace(input));
        }
    }
}
