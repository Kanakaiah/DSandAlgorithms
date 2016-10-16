using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Bhanu
{
    public class NumericBasedProblems
    {
        public static void Test_ReverseGivenNumber()
        {
            int[] numbers = new int[] { -1234, 0, 1111, 5002 };

            foreach(int num in numbers)
            {
                Console.WriteLine("Input Number: {0}, OutputNumber: {1}", num, ReverseNumber(num));
            }
        }

        private static int ReverseNumber(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result = (result * 10) + num % 10;
                num = num / 10;
            }

            return num < 0 ? (result * -1) : result;
        }
    }
}
