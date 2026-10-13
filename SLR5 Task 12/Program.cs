using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 12: TRY Nested While Loops for Right-Angled Triangle Pattern

            /*Explanation: This exercise introduces pattern generation using 
             * nested loops. You will create a right-angled triangle using asterisks.
             * 
             * Task: Complete the code to generate a triangle pattern of asterisks, 
             * where each row has one more asterisk than the previous one.*/

            int rows = 5;
            int i = 1;

            // Outer loop should run through each row
            while (i<= rows)
            {
                int j = 1;

                // Inner loop should print asterisks in each row
                while (j <= i)
                {
                    // Print asterisk without moving to the next line
                    Console.Write("*");

                    // Increment inner loop variable
                    j++;
                }

                // Move to the next line after each row
                Console.WriteLine();

                // Increment outer loop variable
                i++;
            }
            Console.ReadKey();
        }
    }
}
