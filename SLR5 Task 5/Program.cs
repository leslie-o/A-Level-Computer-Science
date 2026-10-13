using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 5: INVESTIGATE   Do-While Loop for Input Validation
            /*Complete the code so that it keeps asking the user to enter a 
            positive number until they do so. Use a do-while loop.*/

            int number;

            // Execute the loop at least once
            do
            {
                // Prompt the user to enter a positive number
                Console.WriteLine("Enter a positive number: ");

                // Read the user input and store it in the variable number
                number = Convert.ToInt32(Console.ReadLine());               
            }
            // Keep looping while the number is less than or equal to 0
            while (number<=0);

            Console.ReadKey();
        }
    }
}
