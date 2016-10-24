using DS.Algorithms.Satish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Alogirthms.Satish
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredStr;
            Console.WriteLine("Welcome to the Alogrithms!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter any String to findout if it is a Palindrome or not");
            do
            {


                enteredStr = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Entered String : " + enteredStr);
                Console.WriteLine();
                int strLength = enteredStr.Length;
                string firstHalf = null;
                string secondHalf = null;
                /*
                for (int i = 0; i < strLength / 2; i++)
                {
                    firstHalf = firstHalf + enteredStr[i];
                } */

                firstHalf = enteredStr.Substring(0, strLength / 2);
                string subStr = enteredStr.Substring(strLength / 2);
                Console.WriteLine("Sub String : " + firstHalf);
                for (int i = 1; i <= strLength / 2; i++)
                {
                    int j = strLength - i;
                    secondHalf = secondHalf + enteredStr[j];
                }
                //   Console.Write("First Half" + firstHalf);
                Console.WriteLine();
                // Console.Write("Second Half :" + secondHalf);
                Console.WriteLine();

                if (firstHalf == secondHalf)
                {
                    Console.WriteLine("Its a Palindrome!");
                }
                else
                {
                    Console.WriteLine("Its not a Palindrome");
                }

                Console.WriteLine();
                Console.WriteLine("Enter any String to findout if it is a Palindrome or not or press Escape to exit");
                Console.WriteLine();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            //  }

            MatrixProcess mp = new MatrixProcess();
            mp.product();
        }
    }
}
