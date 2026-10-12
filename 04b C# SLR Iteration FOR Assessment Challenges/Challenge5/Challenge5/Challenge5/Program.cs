using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int X = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("    ");
            for (int i = 1; i <= X; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");

                else Console.WriteLine(i);
            }

            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
