using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_10
{
    internal class Program
    {//Task 10: TRY Nested For Loop - Multiplication Table (Medium-Hard)
        /* Complete the program to generate a multiplication table for a user-defined number
         * Run the program to test it.
         */

        static void Main(string[] args)
        {
            // Prompt the user to enter a number for which the multiplication table will be generated
            Console.Write("Enter a number for the multiplication table: ");

            // Read the user's input, convert it to an integer, and store it in the variable 'number'
            int number = int.Parse(Console.ReadLine());

            // Print a message indicating the start of the multiplication table for the entered number
            Console.WriteLine("Multiplication table for " + number);

            // for loop that will generate the multiplication table for 'number'
            for (int i = 1; i <= 10; i++)
            {
                // Print the current multiplication result for 'number * i' in each iteration
                // The incomplete part '/* ??? */' is where the multiplication result should be placed
                Console.WriteLine(number + " * " + i + " = " + /* ??? */);
            }
            // The loop ends after displaying the multiplication table from 1 to 10
        }
    }
}
