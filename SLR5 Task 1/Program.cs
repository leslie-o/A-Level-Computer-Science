using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 1: Understanding Check - Debugging Tools
            //find the logic error

            Console.Write("Enter a start value: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an end value: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisble number you want to check: ");
            int div = Convert.ToInt32(Console.ReadLine());
            int total = 0; //running total of numbers divisible by 3
            for (int num = start; num <= end; num++)
            {
                if (num % div == 0)
                {
                    total++;
                    Console.WriteLine("{0} is divisible by {1}", num, div);
                }
            }
            Console.WriteLine("{0} numbers between {1} and {2} are divisible by {3}", total, start, end, div);
        }
    }
}
