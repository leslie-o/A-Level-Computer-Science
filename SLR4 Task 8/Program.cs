using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_8
{
    internal class Program
    {//Task 8: TRY For Loop -  Simple Sum Calculator (Easy)
        /* Task: Complete the program so that it sums the numbers 
         * from 1 to a user-defined number.
         */

        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");

            // Read the user's input, convert it to an integer, and store it in the variable 'number'
            int number = int.Parse(Console.ReadLine());

            // Initialize a variable 'sum' to store the running total of the sum of numbers
            int sum = 0;

            // Start of a for loop to calculate the sum of numbers from 1 to 'number'
            // Complete the for loop to calculate the sum
            for (int i = 1; i <= /* ??? */ ; i++)
            {
                sum += i;
            }

            // After the loop, print the result: the sum of all numbers from 1 to 'number'
            Console.WriteLine("The sum of numbers from 1 to " + number + " is " + sum);
        }
    }
}
