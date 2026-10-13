using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 11: TRY Selection -  Grading System (Hard)
            /*
             * Task: Complete the program to determine the student's 
             * letter grade based on their score using the following ranges:
             * 90 and above: A
             * 80 to 89: B
             * 70 to 79: C
             * 60 to 69: D
             * Below 60: F
             */
            Console.Write("Enter your score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            // Add nested if statements to determine the letter grade
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else
            {
                if (score >= 80)
                {
                    Console.WriteLine("Grade: B");
                }
                // Continue nesting for other grades
            }
        }
    }
}
