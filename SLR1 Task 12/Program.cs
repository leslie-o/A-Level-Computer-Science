using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {//
         // Declare a variable to hold the user's input
            double userInput;

            // Prompt the user to enter a decimal number
            Console.Write("Enter a decimal number: ");
            userInput = Convert.ToDouble(Console.ReadLine());

            // Use Math.Round() to round the number to two decimal places
            double roundedToTwoDecimalPlaces = 

            // Output the rounded number
            Console.WriteLine("The number rounded to two decimal places is: " + roundedToTwoDecimalPlaces);
        }
    }
}
