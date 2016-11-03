using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISCF_Tech_Nov26
{
    class Program
    {
        static void Main(string[] args)
        {
            int userResponse;
            string yayQuestions, nayQuestions;
            int countYay, countNay;

            Console.WriteLine("Welcome to ISCF Tech Bible Quiz !!");
            Console.WriteLine();

            Console.WriteLine("Q1. In what city was Jesus born?");
            Console.WriteLine("1. Judah          2. Jerusalem");
            Console.WriteLine("3. Bethlehem      4. Jericho");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");
            
            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            countYay = 0;
            countNay = 0;
            yayQuestions = "";
            nayQuestions = "";

            if (userResponse == 3)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q1, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q1, ";
            }
//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q2. How many books are in the New Testament?");
            Console.WriteLine("1. 27          2. 32");
            Console.WriteLine("3. 43          4. 47");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 1)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q2, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q2, ";
            }

 
//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q3. How many people did Jesus feed with five loaves of bread and two fish?");
            Console.WriteLine("1. about 5001          2. about 6000");
            Console.WriteLine("3. about 4000          4. about 5000");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 4)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q3, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q3, ";
            }
  
                   
//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q4. Matthew was a _________ by profession.");
            Console.WriteLine("1. Fisherman          2. Tax collector");
            Console.WriteLine("3. Farmer          4. Shepherd");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 2)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q4, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q4, ";
            }
            
                    
//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q5. Who is the first apostle to deny Jesus?");
            Console.WriteLine("1. Luke      2. Paul");
            Console.WriteLine("3. Peter     4. John");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 3)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q5, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q5, ";
            }
           

//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q6. Which Gospel is written by a doctor?");
            Console.WriteLine("1. Matthew      2. Paul");
            Console.WriteLine("3. Peter        4. Luke");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 4)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q6, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q6, ";
            }


//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q7. By what name is Paul of Tarsus known before he begins his missionary activity?");
            Console.WriteLine("1. Raul      2. Paul");
            Console.WriteLine("3. Saul      4. Joel");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 3)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q7, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q7, ";
            }
      

//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q8. Who is the author of the Book of Revelation?");
            Console.WriteLine("1. Raul      2. Paul");
            Console.WriteLine("3. Saul      4. John");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 4)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q8, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q8, ";
            }

    
//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q9. What is the shortest book in the New Testament?");
            Console.WriteLine("1. 2 John      2. Paul");
            Console.WriteLine("3. Saul      4. John");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 1)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q9, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q9, ";
            }

             
//////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Q10. What type of insect did John the Baptist eat in the desert?");
            Console.WriteLine("1. Ant           2. Locusts");
            Console.WriteLine("3. Lady bug      4. Caterpillar");
            Console.WriteLine();
            Console.Write("Type any one of the option from above: ");

            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userResponse == 2)
            {
                countYay = countYay + 1;
                yayQuestions = yayQuestions + "Q10, ";
            }
            else
            {
                countNay = countNay + 1;
                nayQuestions = nayQuestions + "Q10, ";
            }

            Console.WriteLine("Correctly answered questions {0}/10: {1}", countYay, yayQuestions);
            Console.WriteLine("Wrongly answered questions {0}/10: {1}", countNay, nayQuestions);
            double totalPct = (countYay * 100) / 10;
            Console.WriteLine("Total %: {0}", totalPct);
            Console.ReadLine();
            
        }
    }
}
