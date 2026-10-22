using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR6_Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 8: INVESTIGATE   Create a Populated 2D Array

            int[,] matrix = new int[3, 3]; // create a 3x3 empty array

            // Populate the array (fill in the missing indices)
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            // Output the array contents using a nested loop
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t" );
                }
                Console.WriteLine();
            }
        }
    }
    }

