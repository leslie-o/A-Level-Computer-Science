using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 6: INVESTIGATE Nesting IF Statements
            /*
             * Task: Complete the following program by nesting 
             * if statements to check if a number is 
             * positive, negative, or zero, and whether it is even or odd.
             */
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
                /*Add an inner if statement to check if the number is even
                 * hint: use the % operator
                 */
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
                /*Add an inner if statement to check if the number is even
                 * hint: use the % operator
                 */
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
