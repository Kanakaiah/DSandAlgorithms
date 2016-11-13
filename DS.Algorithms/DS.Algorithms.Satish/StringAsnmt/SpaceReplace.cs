using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class SpaceReplace
    {
        public static string Replace(string inString)
        {
            string replaceStr = "%20";
            int spaceCount = 0;
            foreach (char c in inString)
            {
                if (c == ' ')
                    spaceCount++;
            }

            char[] myString = new Char[inString.Length + (2 * spaceCount)];

            int charSize = myString.Length;
            int k = 0;
            for (int i = 0; i < inString.Length; i++)
            {
               
                if (inString[i] == 32)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 0)
                        {
                           // k++; 
                            myString[k] = '%';
                        }
                        else if (j == 1)
                        {
                            k++;
                            myString[k] = '2';
                        }
                          
                        else if (j == 2)
                        {
                            k++;
                            myString[k] = '0';
                        }
                           
                    }
                       
                }
                else
                {
                   
                    myString[k] = inString[i];
                   
                   
                }
                k++;

            }

            //  myString = inString.ToCharArray();

            string output = null;
            foreach(char v in myString)
            {
                output += v;
            }
          

           

          //  return "Spaces in String : " + spaceCount + " String Size :" + inString.Length + "Char Size : "+ myString.Length;
            return output; 
        }
    }
}
