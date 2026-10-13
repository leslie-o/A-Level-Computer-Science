using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_2
{
    internal class Program
    {//Task 2: INVESTIGATE how to use counter-controlled iterations (FOR Loops)
        /* Change the program so that it outputs the message 20 times instead.
         * Run and test your program. 
         */
        static void Main(string[] args)
        {
            // Initialize a string variable 
            string Message = "This is how you get code to repeat.";

            // Start of a for loop that will repeat 10 times
            // The counter variable 'counter' starts at 0 and increments by 1 after each iteration
            // The loop will continue as long as 'counter' is less than 10, so it runs exactly 10 times
            for (int counter = 0; counter < 20; counter++)
            {
                // prints the message stored in 'Message' to the console
                Console.WriteLine(Message);
            }
            // The loop ends after printing the message 10 times
        }
    }
}
