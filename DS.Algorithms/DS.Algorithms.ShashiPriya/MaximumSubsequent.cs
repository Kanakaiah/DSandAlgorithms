using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.ShashiPriya
{
   public static class  MaximumSubsequent
    {

        public static int  MaxSubProduct(int[] arr)
        {
             
            int max = 1;
            int min = 1;
            int prod = 1;
            int maxSoFar = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >0)
                {
                    max = max*arr[i];
                    prod *= arr[i];
                }
                else if (arr[i] < 0)
                {
                    max = 1;
                    //prod = 1;
                    min = min*arr[i];
                   prod *= arr[i];
                }
                else
                {
                    max = 1;
                    min = 1;
                    prod = 1;
                }
                maxSoFar = (max > maxSoFar) ? max : maxSoFar;
                maxSoFar = (prod > maxSoFar) ? prod : maxSoFar;
            }
            Console.WriteLine(maxSoFar);
            Console.ReadLine();
            return maxSoFar;
        }
    }
}
