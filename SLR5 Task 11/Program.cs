using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 11: TRY Calculate Factorial Using While Loop  

            /*Explanation: Factorial is the product of all positive integers 
             * up to a given number. In this exercise, you will use a while 
             * loop to calculate the factorial of a number entered by the user.
             * 
             * Task: Complete the following code to calculate the factorial of a given number.*/

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            int i = 1;

            // Loop should run as long as i is less than or equal to the number
            while (i <= number)
            {
                // Multiply factorial by the current value of i
                factorial *= i;

                // Increment i
                i++;
            }

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
            Console.ReadLine();
        }
    }
}
