 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_6
{
    internal class Program
    {//Task 6: INVESTIGATE  FOR EACH Loops

        static void Main(string[] args)
        {
            // Prompt the user to enter a word
            Console.Write("Enter a word: ");

            // Read the input from the user and store it in the variable 'word'
            string word = Console.ReadLine();

            // Start of a foreach loop to iterate through each character in the string 'word'
            // The 'letter' variable represents each individual character in the word during each loop iteration
            foreach (char letter in word)
            {
                // Print the current character to the console
                Console.WriteLine(letter);
            }
        }
    }
}
