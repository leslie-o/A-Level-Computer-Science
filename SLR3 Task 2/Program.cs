using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 2: INVESTIGATE The IF ELSE Statement
            /*
             * Task: Complete the following program to output whether the 
             * number is positive or negative, using an else statement.
             */

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            
            }
            else Console.WriteLine("The number is negative.");
        }
    }
}
