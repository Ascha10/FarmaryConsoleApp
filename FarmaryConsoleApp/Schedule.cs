using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaryConsoleApp
{
     class Schedule
    {
        public int numberOfWeeks;
        public int dayInWeeks;
        public static void DiaryPatient(int numOfWeeks,int numOfDays)
        {

            int[,] twoDimensionalArray = new int[numOfWeeks, numOfDays];
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Random randomNumber = new Random();
                    if (j == 6) Console.Write($"{twoDimensionalArray[i, j] = 0}\t");
                    else Console.Write($"{twoDimensionalArray[i, j] = randomNumber.Next(1, 10)}\t");
                }
                Console.WriteLine("\n---------------------------------------------------");
            }
        }

        public static void DiaryPatientOf5perDay(int numOfWeeks, int numOfDays)
        {
            int[,] twoDimensionalArray = new int[numOfWeeks, numOfDays];
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Random randomNumber = new Random();

                    if (j == 6)
                    {
                        Console.Write($"{twoDimensionalArray[i, j] = 0}\t");
                    }
                    else
                    {
                        twoDimensionalArray[i, j] = randomNumber.Next(1, 10);

                        if (twoDimensionalArray[i, j] < 5)
                        {
                            Console.Write($"{twoDimensionalArray[i, j]}\t");
                        }
                        else
                        {
                            Console.Write($"bussy\t");
                        }
                    }
                }
                Console.WriteLine("\n---------------------------------------------------");
            }
        }


    }
}
