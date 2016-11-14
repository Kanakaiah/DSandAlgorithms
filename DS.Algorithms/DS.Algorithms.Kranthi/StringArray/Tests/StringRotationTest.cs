using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.StringArray.Tests
{
    class StringRotationTest
    {
        internal static void Run()
        {
            string inputString = "hello";
            string rotatedString = "elloh";
            Console.WriteLine("\"{0}\" and \"{1}\" are rotation of each other: {2}", inputString, rotatedString, StringRotation.IsTrue(inputString, rotatedString));
            Console.WriteLine();

            inputString = "water bottle";
            rotatedString = "bottlewater ";
            Console.WriteLine("\"{0}\" and \"{1}\" are rotation of each other: {2}", inputString, rotatedString, StringRotation.IsTrue(inputString, rotatedString));
            Console.WriteLine();

            inputString = "wet";
            rotatedString = "ertw";
            Console.WriteLine("\"{0}\" and \"{1}\" are rotation of each other: {2}", inputString, rotatedString, StringRotation.IsTrue(inputString, rotatedString));
            Console.WriteLine();
        }
    }
}
