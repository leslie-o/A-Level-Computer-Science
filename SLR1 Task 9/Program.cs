using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 9 : Casting Between Data Types

            // Ask the user for the first number
            Console.WriteLine("Enter the first number:");

            // Get the first number and store it in a variable
            // Note: The input needs to be cast to an integer
            int firstNumber = int.Parse(Console.ReadLine());

            // Ask the user for the second number
            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());


            // TODO: Get the second number and store it in a variable
            // Hint: You'll need to cast the input to an integer


            // TODO: Add the two numbers together and store the result
            int result = firstNumber + secondNumber;
            Console.WriteLine("The result is: " + result);

            // TODO: Print the result of the addition

        }
    }
}
