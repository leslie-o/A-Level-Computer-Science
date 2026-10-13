using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 9: TRY Selection -  Temperature Check (Medium)
            /*
             * Task:Complete the program to check the temperature. 
             * If it's below 10 degrees, output "Cold". 
             * If it's between 10 and 25 degrees, output "Warm". 
             * If it's above 25 degrees, output "Hot".
             */
            Console.Write("Enter the temperature in degrees: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            // Add if-else if-else statements to categorize the temperature
            if (/* condition for Cold */)
            {
                Console.WriteLine("Cold");
            }
            else if (/* condition for Warm */)
            {
                Console.WriteLine("Warm");
            }
            else
            {
                Console.WriteLine("Hot");
            }
        }
    }
}
