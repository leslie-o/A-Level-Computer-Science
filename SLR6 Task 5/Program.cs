using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR6_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 5: INVESTIGATE   Iterating Through a 1D Array Using a For Each Loop

            // Step 1: Declare and populate an integer array of size 5
            int[] numbers = { 5, 10, 15, 20, 25 };

            // Step 2: Use a foreach loop to display each element in the array
            Console.WriteLine("Array elements (using foreach loop):");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
