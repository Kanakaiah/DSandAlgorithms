using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srik_BasicMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            Console.WriteLine("Enter 1st value: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value: ");
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of {0} + {1} = {2}", var1, var2, var1 + var2);
            Console.WriteLine("The difference of {0} - {1} = {2}", var1, var2, var1 - var2);
            Console.WriteLine("The product of {0} * {1} = {2}", var1, var2, var1 * var2);
            Console.ReadLine();
        }
    }
}
