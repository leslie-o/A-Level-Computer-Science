using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR5_Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 9: TRY Do-While Loop with User Choice  

            //Complete the code to keep asking the user if they want to continue. Stop when they input 'n'.
            char choice;

            // Execute the loop at least once
            do
            {
                // Ask the user if they want to continue (y/n)
                Console.WriteLine("Do you want to continue? (y/n): ");

                // Read the user input
                choice = Convert.ToChar(Console.ReadLine());

            }
            // Loop should continue as long as the user inputs 'y'
            while (choice == 'y');
          



                Console.ReadKey();
        }
    }
}
