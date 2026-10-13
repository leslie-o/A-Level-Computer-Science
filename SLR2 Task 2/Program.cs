using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR2_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 2: INVESTIGATE String Concatenation
            string firstName = "Bob";
            string lastName = "Builder";

            // Method 1: Using the + operator
            string fullName1 = firstName + lastName;

            // Method 2: Using string interpolation with $ {varname} (fill in the method)
            string fullName2 = $"{firstName}{lastName}";

            // Method 3: Using string interpolation {0}, {1} etc  (fill in the code)
            string fullName3 = string.Format("{0}{1}{1}{1}{0}",
                firstName, lastName);

            Console.WriteLine("Full Name 1: " + fullName1);
            Console.WriteLine("Full Name 2: " + fullName2);
            Console.WriteLine("Full Name 3: " + fullName3);
        }
    }
}


