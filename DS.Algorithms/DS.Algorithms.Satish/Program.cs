using DS.Algorithms.Satish;
using DS.Algorithms.Satish.StringAsnmt;
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
          //  Console.WriteLine("Enter any String to findout if it is a Palindrome or not");

            /*            do
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

            /*              firstHalf = enteredStr.Substring(0, strLength / 2);
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
                      */
            //Commenting to try other Programs
            //  }

            //      MatrixProcess mp = new MatrixProcess();
            //      mp.product();


            MyStack<string> stack = new MyStack<string>();
            Console.WriteLine("The Stack Size :" + stack.Size);
            stack.push("Genesis");
            Console.WriteLine("The Stack Size :" + stack.Size);
            string str = stack.pop();
            Console.WriteLine("The Popped String  " + str);
            Console.WriteLine();
            Console.WriteLine("The Stack Size :" + stack.Size);
            stack.push("Numbers");
            stack.push("Leviticus");
            stack.push("Psalms");
            Console.WriteLine();
            Console.WriteLine("The Stack Size :" + stack.Size);
            for(int i = 0; i < stack.Size; i++)
            {
                Console.WriteLine("Index :" + i + " Value :" + stack.Get(i));
            }

            stack.pop();
            Console.WriteLine();
            Console.WriteLine("The Stack Size After another Pop :" + stack.Size);

            for (int i = 0; i < stack.Size; i++)
            {
                Console.WriteLine("Index :" + i + " Value :" + stack.Get(i));
            }
            Console.WriteLine();
            Console.WriteLine("Queue Demo!");
            Console.WriteLine();
            MyQueue<string> queue = new MyQueue<string>();
            queue.enqueue("Sathish");
            queue.enqueue("Anusha");
            Console.WriteLine("Queuw Size : "+ queue.Size);
            Console.WriteLine();
            queue.dequeue();
            Console.WriteLine("Queue Size After Deque : " + queue.Size);
            for (int i = 0; i < queue.Size; i++)
            {
                Console.WriteLine("Index :" + i + " Value :" + queue.Get(i));
            }
            Console.WriteLine();
            queue.enqueue("Abhishay");
            queue.enqueue("Sannidhi");

            for (int i = 0; i < queue.Size; i++)
            {
                Console.WriteLine("Index :" + i + " Value :" + queue.Get(i));
            }
            queue.dequeue();

            Console.WriteLine();
            Console.WriteLine("Quue Values after another Deque");
            for (int i = 0; i < queue.Size; i++)
            {
                Console.WriteLine("Index :" + i + " Value :" + queue.Get(i));
            }
            Console.WriteLine("-------------------------------");

            SubSequenceSum subSum = new SubSequenceSum();
            //  subSum.displayArray();
            //  subSum.displaySubSum();
            SubSequenceTest.Run();

            // UniqueCharTest.Run();
            StringAnagramTest.Run();
            
        }
    }
}
