using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.ShashiPriya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Praise the Lord!!!!!");
            Console.WriteLine("Number is palindrome:" + IsPalindrome("madam"));
              Console.WriteLine("Reverse of Number:"+ ReverseNumber(123));
            Console.Read();
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
