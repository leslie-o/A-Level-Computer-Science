using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 4: INVESTIGATE   Input Validation with While Loop
            /*Complete the code to ensure that the user enters a positive number. 
             * If the input is negative or zero, the program should keep asking for a positive number.*/

            int number = -1;

            // Keep asking for a positive number
            while (number <=0)
            {
                // Ask user to input a number
                Console.WriteLine("Enter a positive number: ");

                // Read user input and convert to integer
                number = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.ReadKey();
        }
    }
}
