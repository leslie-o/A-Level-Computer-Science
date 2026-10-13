using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_7
{
    internal class Program
    {//Task 7: INVESTIGATE  Nested FOR Loops
        /* Modify the code to display the multiplication tables for numbers 1 to 5. Run and test your program
         * Add a condition so that if the result is greater than 10, the loop will skip printing that result.
         * Run and test your program. 
         */

        static void Main(string[] args)
        {
            // outer loopcontrols the first multiplier (i)
            // will run 3 times, with 'i' taking values from 1 to 3
            for (int i = 1; i <= 3; i++)
            {
                // inner loop, which controls the second multiplier (j)
                // also runs 3 times, with 'j' taking values from 1 to 3
                for (int j = 1; j <= 3; j++)
                {
                    // This line prints out the result of the multiplication of i and j
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
                // Inner loop ends here
            }
            // Outer loop ends here
        }
    }
}
