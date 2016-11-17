using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringRotationTest
    {
        internal static void Run()
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";
            Console.WriteLine(StringRotation.CheckRotation(s1, s2));

            s1 = "sathishcode";
            s2 = "sathishcode";
            Console.WriteLine(StringRotation.CheckRotation(s1, s2));
        }
    }
}
