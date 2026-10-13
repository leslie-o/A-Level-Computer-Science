using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 3: INVESTIGATE   Countdown with While Loop
            //Complete the code to create a countdown from 10 to 1, printing each number.
            int countdown = 10;

            // Loop should continue as long as countdown is greater than or equal to 1
            while (countdown >=1)
            {
                // Print the current countdown value
                Console.WriteLine($"Countdown value: {countdown}");

                // Decrement the countdown by 1
                countdown--;              
            }


            Console.ReadKey();
        }
    }
}
