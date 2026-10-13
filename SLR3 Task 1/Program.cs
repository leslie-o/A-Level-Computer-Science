using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 1: INVESTIGATE The IF Statement
            /*
             * Task: Complete the following program to check if a user is old enough to vote. 
             * The voting age is 18. The program should ask the user for their age and output a message 
             * if they are eligible to vote. If they are not eligible, the program should not print anything. 
             * */

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Add an if statement to check if the user is 18 or older
            if (age >= 18) Console.WriteLine("You are eligible to vote.");
            
        }
    }
}
