using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR3_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 5: INVESTIGATE The ‘switch’ Statement
            /*
             * Task: Complete the following program to print the 
             * correct day of the week based on the user's 
             * input (1 for Monday, 7 for Sunday).
             */
            Console.Write("Enter a number (1-7) for the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Complete the switch statement
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                    /*complete the switch statement here*/
            }
            switch (day)
            {
                case 2:
                    Console.WriteLine("Tueday");
                    break;
            }
            switch (day)
            {
                case 3:
                    Console.WriteLine("Wednesday");
                    break;

            }
            switch (day)
            {
                case 4:
                    Console.WriteLine("Thursday");
                    break;
            }
            switch (day)
            {
                case 5:
                    Console.WriteLine("Friday");
                    break;
            }
            switch (day)
            {
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
            switch (day)
            {
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
