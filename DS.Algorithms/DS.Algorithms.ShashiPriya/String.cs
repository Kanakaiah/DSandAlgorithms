using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.ShashiPriya
{
    class String
    {

        public bool isUnique(string s)
        {
            bool result = false;

            for(int i=0;i<s.Length;i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i]==s[j])
                    {
                        Console.WriteLine("string is not unique");
                        result = true;
                        break;
                    }
                }
                if (result) break;
            }
            if (!result)
                Console.WriteLine("String is unique");
           

            return result;
            
        }

        public bool isPermutation(string s1,string s2)
        {
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            bool result = true;
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("length of the strings are not same.");
                return result;
            }
            else
            {
                for (int i = 0; i < c1.Length; i++)
                {
                    char c = s1[i];
                    for (int j = 0; j < c2.Length; j++)
                    {
                        if (c == c2[j])
                        {
                            c2[j] = ' ';
                            result = true;
                            break;
                        }
                        else
                        {
                            result = result && false;
                        }
                    }
                    if (!result)
                        break;

                }
                if (result)
                    Console.WriteLine("Strings are permuted");
                else
                    Console.WriteLine("Strings are not permuted");

            }

            return result;
        }

        public string CompressedString(string s)
        {
            string s1 = "";
            int count = 1;
            for(int i=0;i<s.Length;i++)
            {
                i = i + (count - 1);
                count = 1;
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i]==s[j])
                    {
                        count++;
                        if(j==s.Length-1)
                            s1 = s1 + s[i] + count.ToString();

                    }                   
                    else
                    {
                        s1 = s1 +s[i] + count.ToString();
                        break;

                    }
                }
               
            }
            s1 = s.Length < s1.Length ? s : s1;
            return s1;
        }

        public string ReverseString(string s)
        {
            string revString = "";
            string word = "  ";
            for(int i=s.Length-1;i>=0;i--)
            {
                if(s[i]!=' ')
                {
                    word = s[i] + word;
                }
                else
                {
                    revString = revString +" "+ word;
                    word = "";
                }
            }
            revString = revString + "  " + word;
            return revString;
        }

        
    }
}
