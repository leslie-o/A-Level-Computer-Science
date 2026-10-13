using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_3
{
    internal class Program
    {//Task 3: INVESTIGATE how to increment the step counter by different values 
        /* Modify the code to print only even numbers between 1 and 10.
         * Run and test your program. 
         * Extend the program to also print "Even" next to each even number
         * Run and test your program. 
         */
        static void Main(string[] args)
        {
            // Declare and initialize the counter variable 'i' to 1
            // The loop will run as long as 'i' is less than or equal to 10
            for (int i = 1; i <= 10; i++)
            {
                // prints the current value of 'i' to the console

                if (i % 2 == 0)
                    Console.WriteLine(i + " Even");
                else Console.WriteLine(i);
            }
            // The loop ends after 'i' reaches 10 and prints all numbers from 1 to 10
        }
    }
}