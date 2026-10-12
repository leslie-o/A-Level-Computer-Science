using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int lowestNumber = 0;
            if (number1 < number2)

            {lowestNumber = number1; 
                                 }            

            else if (number2 <= number1)
            {lowestNumber = number2;}

            Console.WriteLine("The lowest number is: " + lowestNumber);


        }
    }
}
