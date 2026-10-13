using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 10: TRY Selection -  Leap Year Checker (Medium)
            /*
             * Task: Complete the program to check if the year entered by 
             * the user is a leap year. A year is a leap year if it is 
             * divisible by 4 but not by 100, except if it's divisible by 400.
             */
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Add condition to check if the year is a leap year
            if (/* leap year condition */)
            {
                Console.WriteLine("It is a leap year.");
            }
            else
            {
                Console.WriteLine("It is not a leap year.");
            }
        }
    }
}
