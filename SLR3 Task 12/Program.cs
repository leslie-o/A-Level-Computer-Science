using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 12: INVESTIGATE Selecting Random Numbers
            Random Number = new Random();
            int Dice = Number.Next(1, 7);
            Console.WriteLine("Rolled a {0}", Dice);
        }
    }
}
