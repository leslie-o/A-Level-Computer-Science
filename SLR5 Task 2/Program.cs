using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 2: INVESTIGATE   The Basic While Loop/

            //Complete the following code to print all even numbers from 2 to 20 using a while loop.
            int number = 2;
            while (number <= 20)
            {
                // Print the current value of number
                Console.WriteLine("Current value: " + number);

                // Increment number by 2 to get the next even number
                number += 2;
            }
            Console.ReadKey();
        }
    }
}