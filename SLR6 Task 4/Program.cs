using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR6_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 4: INVESTIGATE   Iterating Through a 1D Array Using a For Loop

            // Step 1: Declare and populate an integer array of size 5
            int[] numbers = { 5, 10, 15, 20, 25 };

            // Step 2: Use a for loop to display each element of the array
            Console.WriteLine("Array elements: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("The numbers are: " + numbers[i]);
            }
        }
    }
}
