using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR6_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 2: INVESTIGATE  Creating and Populating an Empty 1D Array

            // Step 1: Declare an integer array of size 5
            int[] numbers =new int[5];

            // Step 2: Prompt the user for input for each element using direct assignment 
            Console.Write("Enter the 1st number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            // Assign value to the second element here
            Console.Write("Enter the 2nd number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 4th number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 5th number: ");
            numbers[4] = Convert.ToInt32(Console.ReadLine());
            

            // Continue this for all elements...

            // Step 3: Display the numbers
            Console.WriteLine("You entered:" + numbers[0]);
            // Display each array element directly here 
            Console.WriteLine("You entered:" + numbers[1]);
            Console.WriteLine("You entered:" + numbers[2]);
            Console.WriteLine("You entered:" + numbers[3]);
            Console.WriteLine("You entered:" + numbers[4]);

        }
    }
}
