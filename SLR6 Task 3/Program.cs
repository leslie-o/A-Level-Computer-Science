using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR6_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 3: INVESTIGATE   Accessing and Manipulating Elements in a 1D Array

            // Step 1: Declare and populate an integer array of size 5
            int[] numbers = new int[5];

            // Manually populate the array (without loops)
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;
            numbers[3] = 20;
            numbers[4] = 25;

            // Step 2: Access the first element and add 10 to it
            // Write the logic to add 10 to the first element here
            numbers[0] += 10;

            // Step 3: Display the modified array
            Console.WriteLine("Modified array: " + numbers[0]);
            // Display each array element manually here
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);



        }
    }
}
