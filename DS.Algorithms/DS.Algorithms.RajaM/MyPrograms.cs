using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.RajaM
{
    public class MyPrograms
    {
        // private static Dictionary<int, string> myprograms = new Dictionary<int, string>();
        private string[,] myPrograms; // = new string[10, 2];

        public MyPrograms()
        {
            // Make sure you dont enter same number for multiple programs
            myPrograms = new string [,]{
                { "Palindrome", "Palindrome" },
                { "ReverseANumber", "Reverse A Number" },
                { "MatrixMultiplication", "Matrix Multipication" }
            };
        }

        public void PrintMyPrograms()
        {
            for (int i = 0; i < myPrograms.GetLength(0); i++)
            {
                Console.WriteLine(myPrograms[i,1] + ": " + i.ToString());
            }
            Console.Write("Please enter the program you wish to run:");
            int choosenProgramKey = Int32.Parse(Console.ReadLine());
            RunProgram(choosenProgramKey);
        }

        public void RunProgram(int choosenProgramKey=0)
        {
            IRun myProgram = new Palindrome();
            string programToRun = "Palindrome";

            
            if (choosenProgramKey >= 0 && choosenProgramKey < myPrograms.GetLength(0))
            {
                programToRun = myPrograms[choosenProgramKey, 0];
                Console.WriteLine("You have choosen the  program number {0}({1}) program to execute.", choosenProgramKey, programToRun);

                switch (programToRun)
                {
                    case "Palindrome":
                        myProgram = new Palindrome();
                        break;
                    case "ReverseANumber":
                        myProgram = new ReverseANumber();
                        break;
                    case "MatrixMultiplication":
                        myProgram = new MatrixMultiplication();
                        break;
                    default:
                        break;
                }

                myProgram.Run();
            }
            else {
                Console.WriteLine("You have choosen the  program number {0} program to execute, which is not present in the given programs.", choosenProgramKey);
                Console.WriteLine("Please close the program and try again.");
            }
            
        }

    }
}
