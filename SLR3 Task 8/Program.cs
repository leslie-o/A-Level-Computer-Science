using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 8: TRY Selection -  Pass/Fail Check (Easy)
            /*
             * Task:Complete the program to output "Pass" 
             * if the grade is 50 or above, otherwise output "Fail."
             */
            Console.Write("Enter your grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            // Add if-else statements to check the grade
            if (/* condition */)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
