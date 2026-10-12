using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge7___OddParity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary sequence (8 bits): ");
            string sequence = Console.ReadLine();

            int count = 0;

            foreach (char bit in sequence)
            {
                if (bit == '1')
                { count++;
                }


            }


            if (count % 2 != 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }



            Console.ReadKey();


        }
    }
}
