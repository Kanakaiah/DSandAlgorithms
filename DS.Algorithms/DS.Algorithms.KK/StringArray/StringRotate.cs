using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    /// <summary>
    /// 12. Given two strings, s1 and s2, write code to check If s2 is a rotation of s1
    /// using only onecall to a finction(e.g., "waterbottle" is a rotation of "erbottlewat").
    /// </summary>
    
    class StringRotate
    {
        public static bool CheckRotation(string s1,string s2)
        {
           return  s1.Length==s2.Length?(s1 + s1).IndexOf(s2) > -1 ? true : false:false;
        }
    }

    public class StringRotateTest
    {
        public static void Run()
        {
            var s1 = "waterbottle";
            var s2 = "erbottlewat";



            Console.WriteLine("The string '{0}' is{2} a rotation of '{1}'", s1, s2, StringRotate.CheckRotation(s1, s2) ? "" : "not");


            s1 = "waterbottle";
            s2 = "erbottlewa";

            Console.WriteLine("The string '{0}' is{2} a rotation of '{1}'", s1, s2, StringRotate.CheckRotation(s1, s2) ? "" : " not");

        }
    }
}
