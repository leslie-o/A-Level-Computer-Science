using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 7: INVESTIGATE   Nested While Loops

            //Complete the code to display a multiplication table (1 to 5).

            int i = 1;

            // Outer loop should iterate through values from 1 to 5
            while (i <= 5)
            {
                int j = 1;

                // Inner loop should iterate through values from 1 to 5
                while (j <= 5)
                {
                    // Print the product of i and j : (i * j)
                    Console.Write(i * j + "\t");

                    // Increment the inner loop variable j
                    j++;
                }

                // Move to the next line after printing a row
                Console.WriteLine();

                // Increment the outer loop variable i
                i++;
            }
            Console.ReadKey();
        }
    }
}
