using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 10: TRY Accidental Infinite Loop Challenge

            //Task: The partially completed code contains an infinite loop. Analyse and correct it.

            int outer = 5;
            int inner = 0;

            // Outer loop should run as long as outer is greater than 0
            while (outer > 0)
            {
                // Inner loop should run as long as inner is less than 5
                while (inner < 5)
                {
                    // Print the current values of outer and inner
                    Console.WriteLine("Outer: " + outer + ", Inner: " + inner);

                    // Missing code to prevent infinite loop in inner loop
                    inner++;
                }

                // Decrement outer variable
                outer--;
            }
            Console.ReadKey();
        }
    }
}
