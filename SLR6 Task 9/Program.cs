using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR6_Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 9: INVESTIGATE   Create an Empty 2D Array and Populate It Using a For Loop

            int[,] matrix = new int[3, 4]; // Create an empty 3x4 array

            // Fill the array using a nested for loop
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Enter value for matrix[{0}, {1}]: ", i, j);
                    matrix[i,j] = int.Parse(Console.ReadLine()); // Take input from the user
                }
            }

            // Output the array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i , j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
