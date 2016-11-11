using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StringArray
{
    public class RowColumnSetZero
    {
        public static int[,] Change(int[,] mnmtrix)
        {

            //int[,] copy = new int[mnmtrix.GetLength(0), mnmtrix.GetLength(1)];

            bool[] row = new bool[mnmtrix.GetLength(0)];
            bool[] col = new bool[mnmtrix.GetLength(1)];

            for (int i = 0; i < mnmtrix.GetLength(0); i++)
            {

                for (int j = 0; j < mnmtrix.GetLength(1); j++)
                {
                    if (mnmtrix[i, j] == 0)
                    //copy[i, j] = 1;
                    {
                        if (row[i] != true)
                            row[i] = true;
                        if (col[j] != true)
                            col[j] = true;
                    }
                }

            }

            int zeroRowsCount = 0;

            // Replacing all the rows
            for (int i = 0; i < row.Length; i++)
            {

                if (row[i] == true)
                {
                    for (int j = 0; j < col.Length; j++)
                    {
                        mnmtrix[i,j] = 0;
                    }
                    zeroRowsCount++;
                }
                
            }

            //If all the rows are replaced then no need of column level replace
            if(zeroRowsCount== mnmtrix.GetLength(0))
            {
                return mnmtrix;
            }


            //Remaining column level replace 
            for (int i = 0; i < col.Length; i++)
            {

                if (col[i] == true)
                {
                    for (int j = 0; j < mnmtrix.GetLength(0); j++)
                    {
                        if(row[j]!=true)
                        mnmtrix[j, i] = 0;
                    }
                }

            }
            return mnmtrix;
        }
    }


    public class RowColumnSetZeroTest
    {
        public static void Run()
        {

            //input 1
            int[,] inputArray = new int[3, 5] { 
                                                { 1, 0, 3, 0, 5 }, 
                                                { 6, 0, 8, 9, 0 }, 
                                                { 7, 8, 0, 10, 0 } };


            Console.WriteLine("*********Input************");
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    Console.Write(inputArray[i, j] + " ");
                }
            }


            var outputArray = RowColumnSetZero.Change(inputArray);

            Console.WriteLine();
            Console.WriteLine("*********Output************");

            for (int i = 0; i < outputArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < outputArray.GetLength(1); j++)
                {
                    Console.Write(outputArray[i, j] + " ");
                }
            }

            //input 2


            inputArray = new int[3, 5] {
                                                { 1, 5, 3, 6, 5 },
                                                { 6, 0, 8, 9, 0 },
                                                { 7, 8, 0, 10, 0 } };

            Console.WriteLine();

            Console.WriteLine("*********Input************");
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    Console.Write(inputArray[i, j] + " ");
                }
            }


            outputArray = RowColumnSetZero.Change(inputArray);

            Console.WriteLine();
            Console.WriteLine("*********Output************");

            for (int i = 0; i < outputArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < outputArray.GetLength(1); j++)
                {
                    Console.Write(outputArray[i, j] + " ");
                }
            }

        }
    }
}
