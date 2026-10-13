using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 8 : INVESTIGATE Getting and Storing Input

            // Ask the user for their name
            Console.WriteLine("Enter your name:");

            // Get the user's name and store it in a variable
            string name = Console.ReadLine();

            // TODO: Ask the user for their age 
            Console.WriteLine("Enter your age: ");


            // TODO: Get the user's age and store it in the variable age
            string age = Console.ReadLine();

            //Print a greeting message that includes the user's name and age
            Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");
        }
    }
}
