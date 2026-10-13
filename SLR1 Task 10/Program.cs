using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//TASK 10: TRY  Mixing Data Types

            // Ask the user for the first test score
            Console.WriteLine("Enter the first test score:");

            // TODO: Get the first score and store it in a variable
            float firstScore =  Convert.ToInt32(Console.ReadLine());

            // Ask the user for the second test score
            Console.WriteLine("Enter the second test score:");

            // TODO: Get the second score and store it in a variable
            float secondScore = Convert.ToInt32(Console.ReadLine());
            // Ask the user for the third test score

            Console.WriteLine("Enter the third test score:");

            // TODO: Get the third score and store it in a variable
            float thirdScore = Convert.ToInt32(Console.ReadLine());

            // TODO: Calculate the average of the three scores
            // Hint: You'll need to cast the sum to double before dividing
            string sum = Convert.ToDouble((firstScore + secondScore + thirdScore));
            float avg = sum / 3;
            // TODO: Print the average score
            Console.WriteLine("The average is: " + avg);
        }
    }
}
