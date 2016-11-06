using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.JP
{
    class MaximumSubsequenceSum
    {
        static void Main(string[] args)
        {
            // To Calculate Maximum subsequence sum

            int ans = 0;
            int sm = 0;
            Console.WriteLine("Specify number of integers in the list: ");
            int totalNumbers = Convert.ToInt16((Console.ReadLine()));
            int[] inputIntegers = new int[totalNumbers];
            for (int index = 0; index < totalNumbers; index++)
            {
                Console.WriteLine("Please provide your integer # {0}", index);
                inputIntegers[index] = Convert.ToInt16((Console.ReadLine()));
                Console.WriteLine();
                // Console.WriteLine("Your integer # {0} is {1} ", index, inputIntegers[index]);
                if (sm + inputIntegers[index] > 0)
                    sm += inputIntegers[index];
                else
                    sm = 0;
                ans = Math.Max(ans, sm);
            }
            foreach (int number in inputIntegers)
                {
                Console.WriteLine(" ", number);
                }
            Console.WriteLine();
            Console.WriteLine("The Maximum Subsequence Sum of given list is # {0}", ans);
            Console.ReadLine();
        }
    }
}
