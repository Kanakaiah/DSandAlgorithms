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

        public string ReplaceWhiteSpace(string s,int length)
        {
            char[] ch = s.ToCharArray();
            int count = 0;
            for(int i=0;i<length;i++)
            {
                if (s[i] == ' ') count++;
            }
            int newlength = length + (count * 2);
            
            for(int i=length-1;i>=0;i--)
            {
                if (ch[i] == ' ')
                {
                    ch[newlength-1] = '0';
                    ch[newlength - 2] = '2';
                    ch[newlength - 3] = '%';
                    newlength = newlength - 3;
                }
                else
                {
                    ch[newlength - 1] = ch[i];
                    newlength--;
                }
            }
            return new string(ch);
        }

       public bool isInRotation(string s1,string s2)
        {
            bool result = true; 
            string s3 = s1 + s1;
            for(int i=0;i<s3.Length-s2.Length;i++)
            {
                result = true;
                for(int j=0;j<s2.Length;j++)
                {
                    if(s3[i+j]!=s2[j])
                    {
                        result = false;
                        break;
                    }
                }
                if (result) break;               
            }

            if (result) Console.WriteLine("Strings are in rotation");
            else Console.WriteLine("Strings are not in rotation");          

            return result;            
        }

        public int[] ShiftedArray(int[] a,int d,int n)
        {
            int[] temp = new int[d];
            for(int i=0;i<d;i++)
            {
                temp[i] = a[i];
            }

            //shift d
            int j = 0;
            for(int i=0;i<n;i++)
            {
                if((d+i)<n)
                a[i] = a[d + i];
                else
                {
                    a[i] = temp[j];
                    j++;
                }
            }


            return a;

        }
        
    }
}
