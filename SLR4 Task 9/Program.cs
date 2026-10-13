using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_9
{
    internal class Program
    {//Task 9: TRY For Loop -  Even Number Finder (Easy-Medium)
        /* Complete the program so that it prints all even numbers 
         * between 1 and a user-specified number.
         * Run the program to test it.
         */
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");

            // Read the user's input, convert it to an integer, and store it in the variable 'number'
            int number = int.Parse(Console.ReadLine());

            // Print a message indicating that even numbers between 1 and the entered number will be displayed
            Console.WriteLine("Even numbers between 1 and " + number + ":");

            // for loop to check each number between 1 and the value of 'number'
            for (int i = 1; i <= number; i++)
            {
                // Check if the current number 'i' is even
                if (/* ??? */)
                {
                    // If the condition is met, print the number 'i' to the console
                    Console.WriteLine(i);
                }
            }
            // The loop ends when all numbers from 1 to 'number' have been checked
        }
    }
}
