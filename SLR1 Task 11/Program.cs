using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {//TASK 11: TRY  Rounding to the Nearest Whole Number

            // Declare a variable to hold the user's input
            double userInput;

            // Prompt the user to enter a decimal number
            Console.Write("Enter a decimal number: ");
            userInput = Double.Parse(Console.ReadLine());

            // Use Math.Round() to round the number to the nearest whole number
            double roundedNumber = 

            // Output the rounded number
            Console.WriteLine("The rounded number is: " + roundedNumber);
        }
    }
}
