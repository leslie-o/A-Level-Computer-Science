using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 6: INVESTIGATE   Simple Accidental Infinite Loop
            //The code contains an accidental infinite loop. Identify and correct the issue.

            int number = 10;

            // Loop should continue as long as number is greater than 0
            while (number > 0)
            {
                // Print the current value of number
                Console.WriteLine("Number is: " + number);

                number--;
            }
            Console.ReadKey();
        }
    }
}
