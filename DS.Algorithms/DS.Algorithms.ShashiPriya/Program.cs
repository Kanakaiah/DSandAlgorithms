using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.ShashiPriya
{
    class Program
    {
        static void Main()
        {

            String s1 = new String();
           bool r= s1.isRotatedString("water","erwat");
            Console.WriteLine(r.ToString());
            Console.ReadLine();


            MyQueue q= new MyQueue();
            q.EnQueue(1);
            q.EnQueue(2);
            q.EnQueue(3);
            q.DeQueue();
            q.DeQueue();
            Console.WriteLine(q.front.Data);
            Console.ReadLine();
            int[] arr = new int[] { 5, 0, -7, 2, 12, 2 };
            MaximumSubsequent.MaxSubProduct(arr);
           
            
            int[,] a = new int[2,3] { {1,2,3}, {2,3,5} };
            int[,] b = new int[2,2] { {3,4}, {5,6} };
        int[,] c=    Matrix.Multiply(a,b);

            Console.WriteLine("j");
            try
            {
                MyStack s = new MyStack();
                
                Console.WriteLine("Pushing the element to the stack.");
                s.push(1);
                s.push(2);
                s.push(3);
                Console.ReadLine();
                Console.WriteLine("Display the top element.");
                Console.WriteLine(s.Top());
                Console.ReadLine();
                Console.WriteLine("Popping the elemnent from the stack.");
                Console.WriteLine(s.pop());
                Console.ReadLine();
                Console.WriteLine("Display the top element.");
                Console.WriteLine(s.Top());

                Console.WriteLine("Praise the Lord!!!!!");
                Console.WriteLine("Number is palindrome:" + IsPalindrome("madam"));
                Console.WriteLine("Reverse of Number:" + ReverseNumber(123));
                Console.Read();
            }
            catch(MyStack.EmptyStackException ex)
            {
                Console.WriteLine("Stack is empty");
                Console.ReadLine();
            }
        }
        
         public static bool IsPalindrome(string s)
        {           
            int l = s.Length;
            for(int i=0;i<l/2;i++)
            {
                if(s[i]==s[l-1-i]) i++;               
                else return false;               
            }
            return true;
        }

        public static int ReverseNumber(int number)
        {
            int rev = 0;
            while(number>0)
            {                
                rev = (rev*10) + (number % 10);
                number = number / 10;
            }
            return rev;
        }

        


        


    }
}
