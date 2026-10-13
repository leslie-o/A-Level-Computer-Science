using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 4: Investigate Basic Mathematical Operators
            int a = 10;
            int b = 3;

            //Complete the following instructions to carry out basic mathematical operations
            // 1. Calculate the sum of a and b
            int sum = a + b;

            // 2. Calculate the difference between a and b
            int difference = a - b;

            // 3. Calculate the product of a and b
            int product = a * b;

            // 4. Calculate the quotient of a divided by b
            int quotient = a / b;

            // 5. Calculate the remainder of a divided by b
            int remainder = a % b;

            // Output the results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
