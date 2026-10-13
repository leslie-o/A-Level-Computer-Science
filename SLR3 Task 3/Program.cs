using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 3: INVESTIGATE The ELSE IF Statement
            /*
             * Task: Complete the following program by using
             * if, else if, and else to check if a number is 
             * positive, negative, or zero.
             */
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }

            else if (number <0)
                {

                Console.WriteLine("The number is negative.");

            }
            /*Enter an else if statement here check if number is negative*/
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
