using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 4: INVESTIGATE Boolean Operators
            /*
             * Task: Complete the following program to check if 
             * a number is between 10 and 20 or if it is negative.
             */
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Add a condition that checks if number is between 10 and 20
            if (( number >=10 && number <=20) || number < 0)
            {
                Console.WriteLine("The number is between 10 and 20 or it is negative.");
            }
            else
            {
                Console.WriteLine("The number does not meet the condition.");
            }
        }
    }
}
