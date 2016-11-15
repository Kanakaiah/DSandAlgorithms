using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class StringWordReverse
    {
        public static string Reverse(string inString)
        {
            string[] words = inString.Split(' ').ToArray();
            string reveseWord = null;
            foreach(string s in words.Reverse())
            {
                reveseWord = reveseWord + s + ' ';

            }

            return reveseWord;
        }
    }
}
