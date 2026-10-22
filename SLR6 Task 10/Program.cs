using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SLR6_Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 10: TRY Iterating through a 2D  Array – (Exam Question)

            //create a 2D array to store values
            int[,] data = new int[16, 11];
            //1D array to temporarily hold values to be sorted before adding to data array
            int[] oneRow = new int[11];
            Random rnd = new Random();
            int temp;

            //set up of initial data array with random values
            for (int row = 0; row < 16; row++)
            {
                //create one row of random data and sort it
                for (int i = 0; i < 11; i++)
                {
                    temp = rnd.Next(1, 101);
                    oneRow[i] = temp;
                }
                Array.Sort(oneRow);

                //add contents of the row to the columns 2D array
                for (int col = 0; col < 11; col++)
                {
                    data[row, col] = oneRow[col];
                }
            }

            //START YOUR ANSWER HERE:
            int total;
            for (/*Type code here for the outer loop to iterate through columns*/)
            {
                total = /*Type a value here */;
                for (/*Type code here for the outer loop to iterate through rows in the current column*/)
                {
                    //add array value to the column total
                    total = /*Type code here*/;
                }
                Console.WriteLine(/*Type code here to calculate and output the mean for this column*/);
            }
        }
    }
}
