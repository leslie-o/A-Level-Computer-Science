using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_5
{
    internal class Program
    {//Task 5: INVESTIGATE  using a for loop with other programming concepts 
        /* Change the message to, “Should indexes start at 0 or 1? ” to check the program works with different messages.
         * Run and test the program
         * Change the program so that it outputs all the vow?els in a word by using an “if” command inside the loop. 
         * Run and test the program     
         */
        static void Main(string[] args)
        {
            // Initialize a string variable 'Message' with the value "Hello World"
            string Message = "Should indexes start at 0 or 1 ? ";

            // for loop to iterate through each character of the string 'Message'
            for (int i = 0; i < Message.Length; i++)
            {
                // print the current character in the string at position 'i'
                Console.WriteLine("Character {0} of {1} is {2}.", i, Message, Message[i]);
            }
        }
    }
}
