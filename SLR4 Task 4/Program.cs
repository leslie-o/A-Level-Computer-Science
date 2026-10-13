using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_4
{
    internal class Program
    {//Task 4: INVESTIGATE  incrementing and decrementing the step counter
        /*Modify the loop to increment by 3 instead of 2.
         * Run and test your program. 
         * Add a new loop below this that decrements from 20 down to 0 by 2.
         * Run and test your program. 
         */
        static void Main(string[] args)
        {
            // for loop that will continue as long as 'i' is less than or equal to 20
            // After each iteration, 'i' is incremented by 2
            for (int i = 0; i <= 20; i += 3)
            {
                // print the current value of 'i' to the console
                Console.WriteLine(i);
            }

            // The loop ends after 'i' reaches 20 and prints all even numbers from 0 to 20

            for (int x = 20; x >= 0; x -= 2) 
            {
                Console.WriteLine(x);
            }




            Console.ReadKey();
        }
    }
}
