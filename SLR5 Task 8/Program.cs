using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_8
{
    internal class Program//
    {
        static void Main(string[] args)
        {//Task 8: INVESTIGATE   Combining a Conditional Loop with random numbers

            Random dice = new Random();
            int numberRolls = 0;

            //roll a dice until a 6 is rolled
            //In the condition statement the randomn number is generated, what are you checking it against
            do
            {
                numberRolls++;
            }
            while (dice.Next(1,7)!=6);

            //output the number of rolls taken
            Console.WriteLine($"It took {numberRolls} rolls of a dice to roll a 6.");


            Console.ReadKey();
        }
    }
    
}
