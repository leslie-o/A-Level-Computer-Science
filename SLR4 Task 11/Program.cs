using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_11
{
    internal class Program
    {//Task 11: TRY For Loop with Selection -  Number Guesser Game (Hard)
        /* Complete the program so that it asks the user to guess a randomly generated number between 1 and 20. 
         * The user has 5 attempts to guess correctly.
         * Run the program to test it.
         */

        static void Main(string[] args)
        {
            // Generate a random number between 1 and 20 and store it in the variable 'randomNumber'
            Random random = new Random(); 
            int randomNumber = random.Next(1, 21); // Random number between 1 and 20

            // Set the number of attempts the user has to guess the number
            int attempts = 5;

            // Print a message explaining the game to the user
            Console.WriteLine("Guess the number between 1 and 20. You have 5 attempts.");

            //  for loop to give the user 5 attempts to guess the number
            for (int i = 1; i <= attempts; i++)
            {
                // Prompt the user for their guess on the current attempt (i)
                Console.Write("Attempt " + i + ": ");
                // Read the user's guess and store it in the variable 'guess'
                int guess = int.Parse(Console.ReadLine());

                // Add selection logic to check if the guess is correct, too high, or too low
                if (/* ??? */)
                {
                    // If the guess is correct, print a success message
                    Console.WriteLine("Correct! You guessed the number.");
                    // Set 'attempts' to exit the loop early since the user has guessed correctly
                    attempts = attempts+1;
                }
                else if (/* ??? */)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                else
                {
                  // If the guess is too low  prompt the user to guess again
                    Console.WriteLine("Too low. Try again.");
                }
                // If the user has reached the final attempt and has not guessed correctly
                if (i == attempts)
                {
                    // Print a message telling the user they are out of attempts and reveal the correct number
                    Console.WriteLine("Out of attempts! The correct number was " + randomNumber);
                }
            }// The loop ends after 5 attempts or if the user guesses the correct number 
        }
    }
}
