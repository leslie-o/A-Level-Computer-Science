using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 5: Investigate Compund Assignment Operators
         //Replace each commented calculation with the appropriate compound assignment operator.
            int x = 15;

            x = x + 5;

            x = x - 3;

            x = x*2;

            x = x / 4;

            x = x% 2;

            // Output the final value of x
            Console.WriteLine("Final value of x: " + x);
        }
    }
}
